//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using UnityEngine;

namespace EndlessRunnerSpine.LevelPlayer
{
    public class PlayerController : MonoBehaviour
    {
        #region Private Variables
        [SerializeField]
        private GameObject _shield;
        

        private LevelPlayerData _levelPlayerData;
        private LevelData _levelData;
        private WeaponFiring _weaponFiring;
        #endregion

        #region Public Properties
        public double ShieldEnergy { get; set; } = 1;
        public CharacterMovement CharacterMovement { get; private set; }
        public bool IsDead { get; set; } = false;
        public double IsNearDeathZone { get; set; } = 0;
        #endregion

        #region Const Members
        private const string kTagDeathZone = "DeathZone";
        #endregion

        #region Unity Methods
        private void Awake()
        {
            GameManager.onInitializeLevel += OnInitializeLevel;
            _weaponFiring = gameObject.GetComponent<WeaponFiring>();
            CharacterMovement = gameObject.GetComponent<CharacterMovement>();
        }

        private void Update()
        {
            if (IsDead == true)
                IsNearDeathZone = 0;
            else
                IsNearDeathZone = NearDeathZone();


            if (_shield.activeSelf == true)
            {
                ShieldEnergy = ShieldEnergy - 0.1 * Time.deltaTime;
            }
            if(_shield.activeSelf && ShieldEnergy <= 0)
                _shield.SetActive(false);


            if (_levelData != null)
            {
                CharacterMovement.IsOnGround = OnGround();
                CharacterMovement.UpdateMovement();
                _weaponFiring.UpdateFiring();

                if (Input.GetKey(KeyCode.Q) && IsDead == false && ShieldEnergy > 0)
                {
                    _shield.SetActive(true);
                }
                else
                {
                    _shield.SetActive(false);
                }

                if (GameManager.Instance.GameType == Enums.GameMode.Normal)
                {
                    if (GameManager.Instance.GameProgress.CurrentScore >= _levelData.LevelRoundScoreRequired)
                    {
                        IsDead = true;
                        GameManager.Instance.GameProgress.LevelRoundFinished = true;
                    }
                }
            }
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.collider.tag == kTagDeathZone)
            {
                GameManager.Instance.GameProgress.LevelRoundFinished = false;
                IsDead = true;
                
            }
        }
        private void OnDestroy()
        {
            GameManager.onInitializeLevel -= OnInitializeLevel;
        }
        #endregion

        #region Private Methods
        private void OnInitializeLevel(LevelData levelData)
        {
            _levelData = levelData;
            _levelPlayerData = levelData.PlayerData;
            CharacterMovement.InitializeData(_levelData);
            _weaponFiring.SetWeapon(_levelPlayerData.WeaponTypePlayer);
        }

        private bool OnGround()
        {
                Vector2 position = transform.position;
                Vector2 direction = Vector2.down;
               // Debug.DrawRay(position, direction, Color.yellow, 0.5f);
                RaycastHit2D hit = Physics2D.Raycast(position, direction, 0.5f);
                if (hit.collider != null)
                {
                    return true;
                }
                return false;
        }

        private double NearDeathZone()
        {
            Vector3 position = new Vector3(transform.position.x-1.5f, transform.position.y+1, 0);
            Vector2 direction = Vector2.left;
           // Debug.DrawRay(position, direction, Color.yellow,8f);
            RaycastHit2D hit1 = Physics2D.Raycast(position, direction, 8f);
            if (hit1.collider!=null && hit1.transform.tag == kTagDeathZone)
            {
                if((8 - hit1.distance) / 10 >= 0.3)
                    return (8-hit1.distance)/10;
            }
            return 0;
        }
        #endregion
    }
}
