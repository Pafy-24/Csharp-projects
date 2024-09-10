//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using UnityEngine;
using Spine.Unity;
using Spine.Unity.Examples;
using EndlessRunnerSpine.Enums;
using System.Collections;
using System.Collections.Generic;
using EndlessRunnerSpine.LevelEnemy;

namespace EndlessRunnerSpine.LevelPlayer
{
    public class WeaponFiring : MonoBehaviour
    {
        #region Private Variables
        [SerializeField]
        private Sprite _weaponTypeSprite1;

        [SerializeField]
        private Sprite _weaponTypeSprite2;

        [SerializeField]
        private GameObject _reticle;

        [SerializeField]
        private GameObject _weaponOrigin;

        [SerializeField]
        private LayerMask _maskHGZone;

        private LineRenderer _lineShootRenderer;
        private double _reticleTimePassed;
        public double _timeReticleLife = 0.5f;
        private Camera _mainCamera;
        private SpriteAttacher _spriteAttacher;
        private PlayerController _playerController;
        private CharacterMovement _characterMovement;
        private SkeletonAnimation _skeletonAnimation;
        private float xdiff = 0;
        private float ydiff = 0;

        public double _reticleMaxDistance = 500f;
        private double _speed = 1;
        #endregion

        #region Const Members
        private const float kMaxLengthRayShoot = 30;
        private const string kShootAnimation = "shoot";
        private const string kAimAnimation = "aim";
        private const string kEnemyStringName = "Enemy";
        #endregion

        #region Unity Methods
        void Awake()
        {
            _skeletonAnimation = GetComponent<SkeletonAnimation>();
            _spriteAttacher = gameObject.GetComponent<SpriteAttacher>();
            _characterMovement = gameObject.GetComponent<CharacterMovement>();
            _playerController = _characterMovement.gameObject.GetComponent<PlayerController>();
            _lineShootRenderer = gameObject.GetComponent<LineRenderer>();
            _mainCamera = Camera.main;
            _reticleTimePassed = _timeReticleLife;
            Cursor.visible = true;
        }

        void Update()
        {

            _reticleTimePassed += Time.deltaTime;
         //   Debug.Log("TimePassed\n" + _reticleTimePassed);
        //    Debug.Log("initposx\n" + initposx);
        //    Debug.Log("initposy\n" + initposy);
           // Debug.ClearDeveloperConsole();
            if (Input.GetAxis("Mouse X") == 0 || Input.GetAxis("Mouse Y") == 0)
            { 
                HandleReticleAFKState();
               // Debug.Log("Updated x:" + Input.GetAxis("Mouse X"));
               // Debug.Log("Updated y:" + Input.GetAxis("Mouse Y"));
            }
            UpdateReticlePosition();
        }

        #endregion

        #region Public Methods
        public void UpdateFiring()
        {
            UpdateLineRendererFade();

            if (_playerController.IsDead == false)
            {
                UpdateReticlePosition();
                HandleReticleAFKState();
            }
            else
            {
                _reticle.SetActive(false);
            }

            if (Input.GetMouseButtonDown(0))
            {
                if (_playerController.IsDead == false)
                    StartCoroutine(Shoot());
                _reticleTimePassed = 0;
            }
        }

        public void SetWeapon(WeaponType weapon)
        {
            (string, Sprite) resultTypeWeapon = GetTypeOfWeapon(weapon);
            _spriteAttacher.slot = resultTypeWeapon.Item1;
            _spriteAttacher.sprite = resultTypeWeapon.Item2;
            _spriteAttacher.Initialize();
        }
        #endregion

        #region Private Methods
        private IEnumerator Shoot()
        {
            _skeletonAnimation.AnimationState.SetAnimation(1, kShootAnimation, false);
            _skeletonAnimation.state.AddEmptyAnimation(1, 0.5f, 0.1f);
            _skeletonAnimation.AnimationState.SetAnimation(2, kAimAnimation, false);
            _skeletonAnimation.state.AddEmptyAnimation(2, 0.5f, 0.1f);
            yield return new WaitForSeconds(0.08f);

            var rayHit = Physics2D.Raycast(_weaponOrigin.transform.position, (_reticle.transform.position - _weaponOrigin.transform.position).normalized, kMaxLengthRayShoot, _maskHGZone);
            SetLineRendererPosition(rayHit.collider != null ? Vector3.Distance(_weaponOrigin.transform.position, rayHit.transform.position) : kMaxLengthRayShoot);

            if (rayHit.collider != null && rayHit.collider.tag == kEnemyStringName)
            {
                rayHit.collider.gameObject.GetComponent<EnemyController>().HitCount += 1;

                if (_characterMovement.PlayerSpeed >= _characterMovement.TrackSpeed * 0.7)
                {
                    if (rayHit.collider.gameObject.GetComponent<EnemyController>().HitCount == 1)
                    {
                        Destroy(rayHit.collider.gameObject);
                        GameManager.Instance.AddBonusScore();
                    }
                }

                if (_characterMovement.PlayerSpeed < _characterMovement.TrackSpeed * 0.7)
                {
                    if (rayHit.collider.gameObject.GetComponent<EnemyController>().HitCount == 2)
                    {
                        Destroy(rayHit.collider.gameObject);
                        GameManager.Instance.AddBonusScore();
                    }
                }
            }
        }

        private void SetLineRendererPosition(float distance)
        {
            var color = _lineShootRenderer.material.color;
            color.a = 1f;
            _lineShootRenderer.material.color = color;
            _lineShootRenderer.SetPosition(0, _weaponOrigin.transform.position);
            _lineShootRenderer.SetPosition(1, _weaponOrigin.transform.position + (_reticle.transform.position - _weaponOrigin.transform.position).normalized * distance);
        }

        private void UpdateLineRendererFade()
        {
            var color = _lineShootRenderer.material.color;
            if (color.a > 0)
                color.a -= Time.deltaTime * 3;
            _lineShootRenderer.material.color = color;
        }

        private void UpdateReticlePosition()
        {
            //Implementation code:
            //The reticle should move on the screen where the mouse cursor points
            //Use "_reticle" member of this class to move the gameObject on the UI
            //Observation: the reticle is part of the Spine Skeleton structure, so the position should be calculated relative to the player
            //Constraints: the reticle should not go too far away from the player (it's up to you to select a maximum distance)
            
            
             Vector3 mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3 aimdir = (mousePosition - transform.position).normalized;

            xdiff += Input.GetAxis("Mouse X");
            ydiff += Input.GetAxis("Mouse Y");

            // Debug.Log("Cursor pos:" + Input.GetAxisRaw("Mouse X") + ", " + Input.GetAxisRaw("Mouse Y") + "\n");
            //Debug.Log("?position: "+ _reticle.position);
           // var vectorFromParent = _reticle.transform.localPosition + new Vector3( (float)transform.position.x, (float)transform.position.y +, 0)  * Time.deltaTime;
          //  if(vectorFromParent.magnitude > _reticleMaxDistance)
           //     _reticle.transform.localPosition = Vector2.ClampMagnitude(vectorFromParent, (float)_reticleMaxDistance);
           // else
           //     _reticle.transform.localPosition = Vector2.ClampMagnitude(vectorFromParent, vectorFromParent.magnitude);
            
    }

        private void HandleReticleAFKState()
        {
            //Implementation code:
            //Update the reticle visibility when the player doesn't move the mouse cursor
            //Constraints: use "_timeReticleLife" as the maximum time at which the reticle is visible if the mouse cursor is not moved
            //             use "_reticleTimePassed" for maintaining the time from when the mouse was moved last time+
            if (_reticleTimePassed >= _timeReticleLife)
            {
                _reticle.SetActive(false);
                _reticleTimePassed = 0;
            }
            if(_reticleTimePassed < _timeReticleLife)
            {
                _reticle.SetActive(true);
            }
        }

        private (string, Sprite) GetTypeOfWeapon(WeaponType weapon)
        {
            switch (weapon)
            {
                case WeaponType.None:
                    {
                        _lineShootRenderer.startColor = Color.white;
                        _lineShootRenderer.endColor = Color.white;
                        return ("", null);
                    }

                case WeaponType.Normal:
                    {
                        _lineShootRenderer.startColor = Color.red;
                        _lineShootRenderer.endColor = Color.red;
                        return ("gun", _weaponTypeSprite1);
                    }

                case WeaponType.Freeze:
                    {
                        _lineShootRenderer.startColor = Color.blue;
                        _lineShootRenderer.endColor = Color.blue;
                        return ("gun", _weaponTypeSprite2);
                    }
                default:
                    return ("", null);
            }
        }
        #endregion
    }
}