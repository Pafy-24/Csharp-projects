//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using System.Collections.Generic;
using UnityEngine;
using EndlessRunnerSpine.Utils.Interval;
using EndlessRunnerSpine.Utils;

namespace EndlessRunnerSpine.LevelEnemy
{
    [CreateAssetMenu(fileName = "LevelEnemy", menuName = "Endless Runner Spine/Level Enemy Data", order = 2)]
    public class LevelEnemyData : ScriptableObject
    {
        #region Private Variables
        [SerializeField]
        private List<EnemyData> _enemies; //a list with types of enemies available for this level round

        [SerializeField]
        private double _spawnRate; //the spawn rate of an enemy

        [SerializeField]
        private FloatInterval _prioritization; //prioritization of instantiation chances, first percentage applies for the first enemy and so on...
        #endregion

        #region Public Properties
        public List<EnemyData> Enemies
        {
            get
            {
                return _enemies;
            }
        }

        public double SpawnRate
        {
            get
            {
                return _spawnRate;
            }
        }

        public FloatInterval Prioritization
        {
            get
            {
                return _prioritization;
            }
        }
        #endregion
    }
}
