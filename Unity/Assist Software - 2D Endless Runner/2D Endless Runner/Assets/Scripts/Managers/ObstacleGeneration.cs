//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using UnityEngine;
using System.Collections.Generic;
using EndlessRunnerSpine.Enums;

namespace EndlessRunnerSpine.LevelObstacles
{
    public class ObstacleGeneration : MonoBehaviour
    {
        #region Private Variables
        [SerializeField]
        private Transform _crateParent;

        [SerializeField]
        private Transform _hgZoneParent;

        private LevelObstaclesData _levelObstaclesData;
        private ObstacleFactory _obstacleFactory;
        private Obstacle _obstacleFactoryHGZone;
        private Obstacle _obstacleFactoryCrate;
        public double _spawnCratesPerSecond = 0;
        public double _spawnHGZonePerSecond = 0;
        private double _spawnRateCrate;
        private double _spawnRateHGZone;
        private double _spawnCrateTimePassed;
        private double _spawnHGZoneTimePassed;
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
            if (_levelObstaclesData != null && GameManager.Instance.GameOver == false)
            {
             //   StartCoroutine(SpawnCrate(), _spawnRateCrate);
              //  StartCoroutine(SpawnHGZone(), _spawnRateHGZone);
                _spawnHGZoneTimePassed += Time.deltaTime;
                _spawnCrateTimePassed += Time.deltaTime;
                SpawnHGZone();
                SpawnCrate();
            }
        }
        #endregion

        #region Private Methods
        private void SpawnCrate()
        {
            //Implementation code:
            //A new crate should be instantiated based on the crate spawn rate and the prioritization of spawning (use LevelObstaclesData scriptable object from this class)
            //You should use GenerateCrate() function
            if (_spawnCrateTimePassed >= _spawnRateCrate)
            {
                GenerateCrate();
                _spawnCrateTimePassed = 0;
            }
        }

        private void SpawnHGZone()
        {
            //Implementation code:
            //A new HG zone should be instantiated based on the crate spawn rate and the prioritization of spawning (use LevelObstaclesData scriptable object from this class)
            //You should use GenerateHGZone() function
            if (_spawnHGZoneTimePassed >= _spawnRateHGZone)
             {
                 GenerateHGZone();
                 _spawnHGZoneTimePassed = 0;
             }
        }

        private void GenerateCrate()
        {
            //Implementation code:
            //Main functionality of the crate instantiation code
            //You should use the "_obstacleFactory" member from this class in order to obtain the obstacle type for ObstacleController component
            //You can update the class of the factory if it's needed
            _obstacleFactory = new ObstacleFactory();
            _obstacleFactoryCrate = _obstacleFactory.CreateObstacle(ObstacleType.Crate).GenerateObstacle();
            GameObject newobject = Instantiate(_levelObstaclesData.Crate, new Vector2((float)_sizeOfScreenWidth + _mainCamera.transform.position.x, (float)_sizeOfScreenHeight / 4 - _offsetCameraY), _crateParent.transform.rotation, _crateParent.transform);


        }

        private void GenerateHGZone()
        {
            //Implementation code:
            //Main functionality of the HG zone instantiation code
            //You should use the "_obstacleFactory" object from this class in order to obtain the obstacle type for ObstacleController component
            //The dimension zone is constrained based on the data from LevelObstaclesData member present in this class
            //You can update the class of the factory if it's needed
            _obstacleFactory = new ObstacleFactory();
            _obstacleFactoryHGZone = _obstacleFactory.CreateObstacle(ObstacleType.HGZone).GenerateObstacle();
            GameObject newobject = Instantiate(_levelObstaclesData.HGZone, new Vector2((float)_sizeOfScreenWidth + _mainCamera.transform.position.x, (float)_sizeOfScreenHeight / 4 - _offsetCameraY), _hgZoneParent.transform.rotation, _hgZoneParent.transform);
            

        }

        private void OnInitializeLevel(LevelData levelData)
        {
            _mainCamera = Camera.main;
            _levelObstaclesData = levelData.ObstaclesData;
            _sizeOfScreenWidth = (float)(2.0f * levelData.TrackData.ScreenSpace * Mathf.Tan(_mainCamera.fieldOfView * 0.5f * Mathf.Deg2Rad) * _mainCamera.aspect);
            _sizeOfScreenHeight = _sizeOfScreenWidth / _mainCamera.aspect;
            _obstacleFactory = new ObstacleFactory();
            _offsetCameraY = _mainCamera.transform.position.y;

            _spawnRateCrate = 1.00 / _spawnCratesPerSecond;
            _spawnRateHGZone = 1.00 / _spawnHGZonePerSecond;
           // _obstacleFactoryHGZone = _levelObstaclesData.HGZone;
           //  _obstacleFactoryCrate = _levelObstaclesData.Crate;
        }
        #endregion
    }
}