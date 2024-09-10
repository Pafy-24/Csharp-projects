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

namespace EndlessRunnerSpine.LevelCollectables
{
    public class CollectablesGeneration : MonoBehaviour
    {
        #region Private Variables
        [SerializeField]
        private Transform _CoinParent;

        [SerializeField]
        private Transform _PotionParent;

        private LevelCollectablesData _levelCollectablesData;
        private Collectable _CollectableFactoryPotion;
        private Collectable _CollectableFactoryCoin;
        public double _spawnCoinsPerSecond = 0;
        public double _spawnPotionPerSecond = 0;
        private double _spawnRateCoin;
        private double _spawnRatePotion;
        private double _spawnCoinTimePassed;
        private double _spawnPotionTimePassed;
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
            if (_levelCollectablesData != null && GameManager.Instance.GameOver == false)
            {
                //   StartCoroutine(SpawnCoin(), _spawnRateCoin);
                //  StartCoroutine(SpawnPotion(), _spawnRatePotion);
                _spawnPotionTimePassed += Time.deltaTime;
                _spawnCoinTimePassed += Time.deltaTime;
                SpawnPotion();
                SpawnCoin();
            }
        }
        #endregion

        #region Private Methods
        private void SpawnCoin()
        {
            //Implementation code:
            //A new Coin should be instantiated based on the Coin spawn rate and the prioritization of spawning (use LevelCollectablesData scriptable object from this class)
            //You should use GenerateCoin() function
            if (_spawnCoinTimePassed >= _spawnRateCoin)
            {
                GenerateCoin();
                _spawnCoinTimePassed = 0;
            }
        }

        private void SpawnPotion()
        {
            //Implementation code:
            //A new HG zone should be instantiated based on the Coin spawn rate and the prioritization of spawning (use LevelCollectablesData scriptable object from this class)
            //You should use GeneratePotion() function
            if (_spawnPotionTimePassed >= _spawnRatePotion)
            {
                GeneratePotion();
                _spawnPotionTimePassed = 0;
            }
        }

        private void GenerateCoin()
        {
            //Implementation code:
            //Main functionality of the Coin instantiation code
            //You should use the "_CollectableFactory" member from this class in order to obtain the Collectable type for CollectableController component
            //You can update the class of the factory if it's needed
        
            GameObject newobject = Instantiate(_levelCollectablesData.Coin, new Vector2((float)_sizeOfScreenWidth + _mainCamera.transform.position.x, (float)_sizeOfScreenHeight / 4 - _offsetCameraY), _CoinParent.transform.rotation, _CoinParent.transform);


        }

        private void GeneratePotion()
        {
            //Implementation code:
            //Main functionality of the HG zone instantiation code
            //You should use the "_CollectableFactory" object from this class in order to obtain the Collectable type for CollectableController component
            //The dimension zone is constrained based on the data from LevelCollectablesData member present in this class
            //You can update the class of the factory if it's needed

            GameObject newobject = Instantiate(_levelCollectablesData.Potion, new Vector2((float)_sizeOfScreenWidth + _mainCamera.transform.position.x, (float)_sizeOfScreenHeight / 4 - _offsetCameraY), _PotionParent.transform.rotation, _PotionParent.transform);


        }

        private void OnInitializeLevel(LevelData levelData)
        {
            _mainCamera = Camera.main;
            _levelCollectablesData = levelData.CollectablesData;
            _sizeOfScreenWidth = (float)(2.0f * levelData.TrackData.ScreenSpace * Mathf.Tan(_mainCamera.fieldOfView * 0.5f * Mathf.Deg2Rad) * _mainCamera.aspect);
            _sizeOfScreenHeight = _sizeOfScreenWidth / _mainCamera.aspect;
            _offsetCameraY = _mainCamera.transform.position.y;
            _spawnRateCoin = 1.00 / _spawnCoinsPerSecond;
            _spawnRatePotion = 1.00 / _spawnPotionPerSecond;
            // _CollectableFactoryPotion = _levelCollectablesData.Potion;
            //  _CollectableFactoryCoin = _levelCollectablesData.Coin;
        }
        #endregion
    }
}