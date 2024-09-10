//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using UnityEngine;
using EndlessRunnerSpine.Utils.Interval;

namespace EndlessRunnerSpine.LevelObstacles
{
    [CreateAssetMenu(fileName = "LevelObstacles", menuName = "Endless Runner Spine/Level Obstacles Data", order = 1)]
    public class LevelObstaclesData : ScriptableObject
    {
        #region Private Variables
        [SerializeField]
        private double _spawnRateCrate; //the spawn rate for crate obstacles

        [SerializeField]
        private double _spawnRateHGZone; //the spawn rate for HG zone obstacles

        [SerializeField]
        private FloatInterval _HGZoneDimension; //a range of minimum and maximum available dimensions for HG zone
    
        [SerializeField]
        private FloatInterval _prioritizationObstaclesType; //prioritization of instantiation chances, first percentage applies for the first obstacle and so on...

        [SerializeField]
        private GameObject _crate; //the crate prefab

        [SerializeField]
        private GameObject _hgZone; //the HG zone prefab
        #endregion

        #region Public Properties
        public FloatInterval HGZoneDimension
        {
            get
            {
                return _HGZoneDimension;
            }
        }

        public double SpawnRateCrate
        {
            get
            {
                return _spawnRateCrate;
            }
        }

        public double SpawnRateHGZone
        {
            get
            {
                return _spawnRateHGZone;
            }
        }
        
        public GameObject Crate
        {
            get
            {
                return _crate;
            }
        }

        public GameObject HGZone
        {
            get
            {
                return _hgZone;
            }
        }

        public FloatInterval PrioritizationObstaclesType
        {
            get
            {
                return _prioritizationObstaclesType;
            }
        }
        #endregion
    }
}

