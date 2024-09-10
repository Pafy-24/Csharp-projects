//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using UnityEngine;

namespace EndlessRunnerSpine.LevelTrack
{
    public class DeathZoneEffects : MonoBehaviour
    {
        #region Const Members
        private const string kTagHGZone = "HGZone";
        #endregion

        #region Unity Methods
        private void OnTriggerExit2D(Collider2D collision)
        {
            if (collision.gameObject.tag.Equals(kTagHGZone))
            {
                Destroy(collision.gameObject);
            }
        }
        #endregion
    }
}
