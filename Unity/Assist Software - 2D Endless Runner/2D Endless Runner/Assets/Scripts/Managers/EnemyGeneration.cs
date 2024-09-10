//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using EndlessRunnerSpine.LevelTrack;
using UnityEngine;
using System.Collections.Generic;
using EndlessRunnerSpine.Utils;
using EndlessRunnerSpine.Utils.Interval;
using EndlessRunnerSpine.Enums;
using EndlessRunnerSpine.LevelEnemy;

namespace EndlessRunnerSpine.LevelEnemy
{
    public class EnemyGeneration : MonoBehaviour
    {
        #region Private Variables
        [SerializeField]
        private GameObject _enemyParent;

        private double _enemySpawnRate;
        public double _spawnEnemyPerSecond = 2;
        private double _spawnEnemyTimePassed;

        private LevelEnemyData _levelEnemyData;
        private LevelTrackData _levelTrackData;


        private Camera _mainCamera;
        private double _sizeOfScreenWidth;
        private double _sizeOfScreenHeight;
        private float _offsetCameraY;
        #endregion

        #region Unity Methods
        private void Awake()
        {
            GameManager.onInitializeLevel += OnInitializeLevel;
        }

        private void Update()
        {
            //Implementation code:
            //A new enemy should be instantiated on the track at a specific spawn rate (data from LevelEnemyData scriptable object, member of this class)
            //GenerateEnemy() function should be used
            if (_levelEnemyData != null && GameManager.Instance.GameOver == false)
            {
                _spawnEnemyTimePassed += Time.deltaTime;
                SpawnEnemy();
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
            _levelTrackData = levelData.TrackData;
            _levelEnemyData = levelData.EnemyData;

            _mainCamera = Camera.main;
            _sizeOfScreenWidth = (float)(2.0f * _levelTrackData.ScreenSpace * Mathf.Tan(_mainCamera.fieldOfView * 0.5f * Mathf.Deg2Rad) * _mainCamera.aspect);
            _sizeOfScreenHeight = _sizeOfScreenWidth / _mainCamera.aspect;
            _offsetCameraY = _mainCamera.transform.position.y;


            _enemySpawnRate = 1.00 / _spawnEnemyPerSecond;
        }

        private void SpawnEnemy()
        {
            //Implementation code:
            //A new crate should be instantiated based on the crate spawn rate and the prioritization of spawning (use LevelObstaclesData scriptable object from this class)
            //You should use GenerateCrate() function
            if (_spawnEnemyTimePassed >= _enemySpawnRate)
            {
                GenerateEnemy();
                _spawnEnemyTimePassed = 0;
            }
        }

        private void GenerateEnemy()
        {
            //Implementation code:
            //Based on the prioritization (LevelEnemyData scriptable object), one enemy at the time should be instantiated from scriptable object
            //You should instantiate an enemy of type GoblinBoy or GoblinGirl (enum from Enums.cs class)
            GameObject newobject = Instantiate(_levelEnemyData.Enemies[0].Skeleton, new Vector2((float)_sizeOfScreenWidth + _mainCamera.transform.position.x, (float)_sizeOfScreenHeight / 4 - _offsetCameraY), _enemyParent.transform.rotation, _enemyParent.transform);

        }
        #endregion
    }
}
