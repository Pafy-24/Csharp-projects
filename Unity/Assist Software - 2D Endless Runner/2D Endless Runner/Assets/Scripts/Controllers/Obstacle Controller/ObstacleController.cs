//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using EndlessRunnerSpine.LevelPlayer;
using System.Collections;
using UnityEngine;
using EndlessRunnerSpine.LevelTrack;

namespace EndlessRunnerSpine.LevelObstacles
{
    public class ObstacleController : MonoBehaviour
    {
        #region Private Variables
        public Obstacle obstacle;
        #endregion

        #region Const Members
        private float kImpulseForceCrateCollision = 0.5f;
        private const string kTagDeathZone = "DeathZone";
        private const string kTagPlayer = "Player";
        private const string kTagCrate = "Crate";
        private const string kTagHGZone = "HGZone";
        #endregion

        #region Unity Methods
        /*
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.tag.Equals(kTagPlayer))
            {
                obstacle.OnEnter(other.gameObject.GetComponent<PlayerController>());
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.gameObject.tag.Equals(kTagPlayer))
            {
                obstacle.OnExit(other.gameObject.GetComponent<PlayerController>());
            }
        }
        */
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag.Equals(kTagDeathZone))
            {
                Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
                StartCoroutine(AutoDestroy());
            }

            if (gameObject.tag.Equals(kTagCrate) && collision.gameObject.tag.Equals(kTagPlayer) && collision.contacts[0].normal == Vector2.up)
            { 
                return;
            }

            if(gameObject.tag.Equals(kTagHGZone) && collision.gameObject.tag.Equals(kTagPlayer))
            {
                StartCoroutine(Camera.main.GetComponent<CameraController>().StartChromaticAberrationEffect());
            }

            if (collision.gameObject.tag.Equals(kTagPlayer))
            {
                //obstacle.OnEnter(collision.gameObject.GetComponent<PlayerController>());
                gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(kImpulseForceCrateCollision, 0), ForceMode2D.Impulse);
            }
        }
        #endregion

        #region Private Methods
        private IEnumerator AutoDestroy()
        {
            yield return new WaitForSeconds(1f);
            Destroy(gameObject);
        }
        #endregion
    }
}
