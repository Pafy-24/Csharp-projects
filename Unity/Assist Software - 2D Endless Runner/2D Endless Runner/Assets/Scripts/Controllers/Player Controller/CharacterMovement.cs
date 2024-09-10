//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
// contact assist at  contact@assist.ro
//

using UnityEngine;
using Spine.Unity;
using EndlessRunnerSpine.LevelTrack;

namespace EndlessRunnerSpine.LevelPlayer
{
    public class CharacterMovement : MonoBehaviour
    {
        #region Private Variables
        [SerializeField]
        private BoxCollider2D _playerBoxCollider2D;

        [SerializeField]
        private GameObject _shield;

        private LevelTrackData _levelTrackData;
        private LevelPlayerData _levelPlayerData;
        private LevelData _levelData;

        private PlayerController _playerController;
        private SkeletonAnimation _skeletonAnimation;
        private Rigidbody2D _playerRigidBody2D;
        private Camera _mainCamera;
        private CameraController _cameraController;
        private string _currentAnimation;
        private float _initialTrackSpeed;
        private float _playerSpeed;
        private float _playerSpeedMax;
        private bool _deathEffect;
        #endregion

        #region Const Members
        private const float kPercentPlayerSpeedMax = 0.3f;
        private const float kPercentPlayerSpeedReduce = 0.3f;
        private const double kPercentPlayerSpeed = 0.3f;
        private const float kScaleSpeedHGZone = 0.6f;
        private const float kScaleSpeedNormal = 1f;
        private const string kNameAnimationIdle = "idle";
        private const string kNameAnimationWalk = "walk";
        private const string kNameAnimationRun = "run";
        private const string kNameAnimationJump = "jump";
        private const string kNameAnimationDeath = "death";
        private const string kEnemyStringTag = "Enemy";
        #endregion

        #region Public Properties
        public bool InHGZone { get; set; } = false;
        public bool IsOnGround { get; set; } = false;

        public double PlayerSpeed
        {
            get => _playerSpeed;
            set => _playerSpeed = (float)value;
        }

        public double TrackSpeed
        {
            get => _levelTrackData.SpeedTrack;
        }
        #endregion

        #region Unity Methods
        private void Awake()
        {
            _mainCamera = Camera.main;
            _playerController = GetComponent<PlayerController>();
            _cameraController = _mainCamera.GetComponent<CameraController>();
            _skeletonAnimation = gameObject.GetComponent<SkeletonAnimation>();
            _playerRigidBody2D = GetComponent<Rigidbody2D>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.tag == kEnemyStringTag)
            {
                _playerSpeed *= kPercentPlayerSpeedReduce;
                Destroy(collision.gameObject);
            }
        }

        private void OnDestroy()
        {
            if (_levelTrackData != null)
                _levelTrackData.SpeedTrack = _initialTrackSpeed;
        }
        #endregion

        #region Public Methods
        public void InitializeData(LevelData levelData)
        {
            _levelData = levelData;
            _levelTrackData = levelData.TrackData;
            _levelPlayerData = levelData.PlayerData;
            _playerSpeed = (float)_levelTrackData.SpeedTrack;
            _playerSpeedMax = (float)(_levelTrackData.SpeedTrack + _levelTrackData.SpeedTrack * kPercentPlayerSpeedMax);
            _initialTrackSpeed = (float)_levelTrackData.SpeedTrack;
        }


        public void UpdateMovement()
        {
            if (_levelData != null)
            {
                if (InHGZone == true && _shield.activeSelf == false)
                {
                    StartCoroutine(_cameraController.StartChromaticAberrationEffect());
                    _skeletonAnimation.timeScale = kScaleSpeedHGZone;
                    _playerRigidBody2D.velocity = new Vector2((float)(_playerSpeed * kScaleSpeedHGZone), _playerRigidBody2D.velocity.y);
                }
                else
                {
                    StartCoroutine(_cameraController.StopChromaticAberrationEffect());
                    _skeletonAnimation.timeScale = kScaleSpeedNormal;
                    _playerRigidBody2D.velocity = new Vector2((float)(_playerSpeed), _playerRigidBody2D.velocity.y);
                }

                if (_playerController.IsDead == false)
                {
                    PlayerDeadStateMovement();
                }
                else
                {
                    PlayerAliveStateMovement();
                }
            }
        }
        #endregion

        #region Private Methods
        private void PlayerDeadStateMovement()
        {
            if (IsOnGround == true)
            {
                if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
                {
                    if (_playerSpeed < _playerSpeedMax)
                        _playerSpeed = (float)(_playerSpeed + _levelPlayerData.AccelerationPlayer * Time.deltaTime);
                }
                else
                    if (_playerSpeed > 0)
                    _playerSpeed = (float)(_playerSpeed - _levelPlayerData.AccelerationPlayer * Time.deltaTime);
            }

            if (transform.position.x >= _mainCamera.transform.position.x)
                _playerSpeed = (float)(_levelTrackData.SpeedTrack);

            if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) && IsOnGround == true)
            {
                _playerRigidBody2D.AddForce(new Vector2(0, (float)_levelPlayerData.ImpulseForce), (ForceMode2D)ForceMode.Impulse);
            }

            UpdateTypeAnimation();
        }

        private void PlayerAliveStateMovement()
        {
            GameManager.Instance.GameOver = true;

            if (_levelTrackData.SpeedTrack > 0)
                _levelTrackData.SpeedTrack = (float)(_levelTrackData.SpeedTrack - _initialTrackSpeed * Time.deltaTime);
            else
                _levelTrackData.SpeedTrack = 0;

            if (IsOnGround == true)
            {
                if (GameManager.Instance.GameProgress.LevelRoundFinished == false)
                {
                    _playerSpeed = 0;
                    SetAnimation(kNameAnimationDeath, false);
                    if (_deathEffect == false)
                    {
                        _playerBoxCollider2D.size = new Vector2(_playerBoxCollider2D.size.y, _playerBoxCollider2D.size.x);
                        _deathEffect = true;
                    }

                    GameManager.Instance.OnGameOver();
                }
                else
                {
                    if (_playerSpeed > 0)
                    {
                        _playerSpeed = (float)_levelTrackData.SpeedTrack;
                        UpdateTypeAnimation();
                    }
                    else
                    {
                        _playerSpeed = 0;
                    }
                }
            }
        }

        private void UpdateTypeAnimation()
        {
            if (IsOnGround == true)
            {
                if (_playerSpeed <= 0)
                {
                    SetAnimation(kNameAnimationIdle, true);
                }

                if (_playerSpeed > 0 && _playerSpeed < _levelTrackData.SpeedTrack * kPercentPlayerSpeed)
                {
                    SetAnimation(kNameAnimationWalk, true);
                }

                if (_playerSpeed >= _levelTrackData.SpeedTrack * kPercentPlayerSpeed)
                {
                    SetAnimation(kNameAnimationRun, true);
                }
            }
            else
                SetAnimation(kNameAnimationJump, false);
        }

        private void SetAnimation(string nameAnimation, bool loop)
        {
            if (_currentAnimation != nameAnimation)
            {
                _skeletonAnimation.state.SetAnimation(0, nameAnimation, loop);
                _currentAnimation = nameAnimation;
            }
        }

        #endregion
    }
}
