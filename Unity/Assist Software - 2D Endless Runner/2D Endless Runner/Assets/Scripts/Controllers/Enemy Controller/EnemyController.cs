//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using UnityEngine;
using System.Collections;
using EndlessRunnerSpine.Utils.Interval;

namespace EndlessRunnerSpine.LevelEnemy
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class EnemyController : MonoBehaviour
    {
        #region Private Variables
        private Rigidbody2D _rigidbody2D;
        private double _jumpTimeRate = 0;
        private double _jumpTimePassed;
        private float _speedEnemy = 1.7f;
        #endregion

        #region ReadOnly Members
        private readonly FloatInterval _jumpRange = new FloatInterval(1f, 5f);
        #endregion

        #region Const Members
        private const float kImpulseJumpForce = 10f;
        #endregion

        #region Public Properties
        public int HitCount { get; set; } = 0;
        #endregion

        #region Unity Methods
        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _jumpTimeRate = Random.Range(_jumpRange._min, _jumpRange._max);
        }

        private void Update()
        {
            //Implementation code:
            //The enemy should move in the direction of the player
            //Constraints: you should use "_speedEnemy" member of this class
            _rigidbody2D.position = new Vector2(_rigidbody2D.transform.position.x - _speedEnemy/50, _rigidbody2D.transform.position.y);

            //_rigidbody2D.AddForce(-transform.right * _speedEnemy/50, ForceMode2D.Impulse);
            if (GameManager.Instance.GameOver == false)
            {
                _jumpTimePassed += Time.deltaTime;
                RandomJump();
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //Implementation code:
            //The enemy should interact with:
            //  => The limit death zone from the left part of the screen (the enemy should be destroyed after 2 seconds after collision)
            //  => The crates (the enemy should jump over the crates when is near to them)
            //
            //The collider components from enemies and crates/death zone are not set as triggers, so you need to find a way to trigger the collision, but ignore it afterward
            if (collision.collider.tag == "Crate")
            {
                Jump();
            } else if(collision.collider.tag == "DeathZone")
            {

                Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
                StartCoroutine(AutoDestroy());
            }
        }
        #endregion

        #region Private Methods
        private void RandomJump()
        {
            //Implementation code:
            //At a random rate obtained from "_jumpRange" member of this class, the enemy should jump (use his rigidbody for physics).
            //Constraints: you should use "kImpulseJumpForce" const member of this class for the jump
            if (_jumpTimePassed >= _jumpTimeRate)
            {
                Jump();
                _jumpTimePassed = 0;
            }
        }

        private void Jump()
        {
            _rigidbody2D.AddForce(new Vector2(0, kImpulseJumpForce), (ForceMode2D)ForceMode.Impulse);

        }

        private IEnumerator AutoDestroy()
        {
            yield return new WaitForSeconds(1f);
            Destroy(gameObject);
        }
        #endregion
    }
}
