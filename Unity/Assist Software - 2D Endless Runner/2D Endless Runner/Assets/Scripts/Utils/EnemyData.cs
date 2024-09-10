//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using UnityEngine;
using EndlessRunnerSpine.Enums;
using Spine.Unity;

namespace EndlessRunnerSpine.Utils
{
    [System.Serializable]
    public class EnemyData
    {
        #region Private variables
        [SerializeField]
        private GameObject _skeleton;

        [SerializeField]
        private EnemyType _enemyType;
        #endregion

        #region Public Properties
        public GameObject Skeleton
        {
            get
            {
                return _skeleton;
            }
        }

        public EnemyType EnemyType
        {
            get
            {
                return _enemyType;
            }
        }
        #endregion
    }
}
