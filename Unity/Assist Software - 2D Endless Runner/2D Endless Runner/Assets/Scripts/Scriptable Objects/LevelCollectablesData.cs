//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using UnityEngine;
using EndlessRunnerSpine.Utils.Interval;

namespace EndlessRunnerSpine.LevelCollectables
{
    [CreateAssetMenu(fileName = "LevelCollectables", menuName = "Endless Runner Spine/Level Collectables Data", order = 1)]
    public class LevelCollectablesData : ScriptableObject
    {
        #region Private Variables
        [SerializeField]
        private double _spawnRateCoin;

        [SerializeField]
        private double _spawnRatePotion; 

        [SerializeField]
        private FloatInterval _prioritizationCollectablesType; 

        [SerializeField]
        private GameObject _coin;  

        [SerializeField]
        private GameObject _potion;  
        #endregion

        #region Public Properties

        public double SpawnRateCoin
        {
            get
            {
                return _spawnRateCoin;
            }
        }

        public double SpawnRatePotion
        {
            get
            {
                return _spawnRatePotion;
            }
        }

        public GameObject Coin
        {
            get
            {
                return _coin;
            }
        }

        public GameObject Potion
        {
            get
            {
                return _potion;
            }
        }

        public FloatInterval PrioritizationCollectablesType
        {
            get
            {
                return _prioritizationCollectablesType;
            }
        }
        #endregion
    }
}

