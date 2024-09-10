//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using UnityEngine;
using EndlessRunnerSpine.LevelPlayer;
using EndlessRunnerSpine.LevelEnemy;
using EndlessRunnerSpine.LevelTrack;
using EndlessRunnerSpine.LevelObstacles;
using EndlessRunnerSpine.LevelCollectables;

namespace EndlessRunnerSpine
{
    [CreateAssetMenu(fileName = "LevelData", menuName = "Endless Runner Spine/Level Data", order = 5)]
    public class LevelData : ScriptableObject
    {
        #region Private Variables
        [SerializeField]
        private LevelPlayerData _playerData;

        [SerializeField]
        private LevelEnemyData _enemyData;

        [SerializeField]
        private LevelTrackData _trackData;

        [SerializeField]
        private LevelObstaclesData _obstaclesData;


        [SerializeField]
        private LevelCollectablesData _collectableData;

        [SerializeField]
        private float _levelRoundScoreRequired;

        #endregion

        #region Public Properties

        public LevelCollectablesData CollectablesData
        {
            get
            {
                return _collectableData;
            }
        }

        public LevelPlayerData PlayerData
        {
            get
            {
                return _playerData;
            }
        }

        public LevelEnemyData EnemyData
        {
            get
            {
                return _enemyData;
            }
        }

        public LevelTrackData TrackData
        {
            get
            {
                return _trackData;
            }
        }

        public LevelObstaclesData ObstaclesData
        {
            get
            {
                return _obstaclesData;
            }
        }
        public float LevelRoundScoreRequired
        {
            get =>  _levelRoundScoreRequired;
            set => _levelRoundScoreRequired = value;
        }

        #endregion
    }
}