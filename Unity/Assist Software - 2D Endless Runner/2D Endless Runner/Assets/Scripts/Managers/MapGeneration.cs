//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using EndlessRunnerSpine.Enums;
using System.Collections.Generic;
using UnityEngine;

namespace EndlessRunnerSpine.LevelTrack
{
    public class MapGeneration : MonoBehaviour
    {
        #region Private Variables
        [SerializeField]
        private GameObject _trackParent;

        [SerializeField]
        private GameObject _limitRightZonePrefab;

        private LevelTrackData _levelTrackData;
        private List<GameObject> _floorTilesList = new List<GameObject>();
        private List<GameObject> _backgroundTilesList = new List<GameObject>();
        private List<GameObject> _ceilingTilesList = new List<GameObject>();
        private GameObject _limitRightZone;
        private GameObject _spriteRendererCeiling;
        private GameObject _spriteRendererBackground;
        private GameObject _spriteRendererFloor;
        private GameObject _spriteRendererDeathZone;
        private float _distanceBetweenCeilingFloor;
        private float _dimensionTileFloor;
        private float _dimensionTileBackground;
        private float _dimensionTileCeiling;
        private float _routeDistanceCeiling = 0;
        private float _routeDistanceFloor = 0;
        private float _routeDistanceBackground = 0;
        private float _sizeOfScreenWidth;
        private float _sizeOfScreenHeight;
        private float _offsetCameraY;
        private Camera _mainCamera;
        #endregion

        #region Unity Methods
        private void Awake()
        {
            GameManager.onInitializeLevel += OnInitializeLevel;
        }

        void FixedUpdate()
        {
            if (_levelTrackData != null)
            {
                _routeDistanceFloor += (float)_levelTrackData.SpeedTrack * Time.deltaTime;
                _routeDistanceBackground += (float)_levelTrackData.SpeedTrack * Time.deltaTime;
                _routeDistanceCeiling += (float)_levelTrackData.SpeedTrack * Time.deltaTime;

                _spriteRendererDeathZone.transform.position = new Vector2((float)(_spriteRendererDeathZone.transform.position.x + _levelTrackData.SpeedTrack * Time.deltaTime), _offsetCameraY);
                _limitRightZone.transform.position = new Vector2((float)(_limitRightZone.transform.position.x + _levelTrackData.SpeedTrack * Time.deltaTime), _offsetCameraY);

                if (_routeDistanceFloor >= _dimensionTileFloor)
                {
                    _routeDistanceFloor = 0;
                    ChangePositionTile(_floorTilesList, _dimensionTileFloor);
                }

                if (_routeDistanceBackground >= _dimensionTileBackground)
                {
                    _routeDistanceBackground = 0;
                    ChangePositionTile(_backgroundTilesList, _dimensionTileBackground);
                }

                if (_routeDistanceCeiling >= _dimensionTileCeiling)
                {
                    _routeDistanceCeiling = 0;
                    ChangePositionTile(_ceilingTilesList, _dimensionTileCeiling);
                }
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
            _mainCamera = Camera.main;
            _levelTrackData = levelData.TrackData;
            _spriteRendererCeiling = _levelTrackData.CeilingType;
            _spriteRendererBackground = _levelTrackData.BackgroundType;
            _spriteRendererFloor = _levelTrackData.FloorType;
            _spriteRendererDeathZone = _levelTrackData.DeathZone;
            _sizeOfScreenWidth = (float)(2.0f * _levelTrackData.ScreenSpace * Mathf.Tan(_mainCamera.fieldOfView * 0.5f * Mathf.Deg2Rad) * _mainCamera.aspect);
            _sizeOfScreenHeight = _sizeOfScreenWidth / _mainCamera.aspect;
            _offsetCameraY = _mainCamera.transform.position.y;
            _distanceBetweenCeilingFloor = (float)_levelTrackData.DistanceBetweenCeilingFloor;

            InstantiateFloorObject();
            InstantiateBackgroundObject();
            InstantiateCeilingObject();
            InstantiateDeathZoneAndLimitRightZone();
        }

        private void InstantiateFloorObject()
        {
            _dimensionTileFloor = _spriteRendererFloor.GetComponent<SpriteRenderer>().bounds.extents.x * 2;
            Vector2 sizeMapTile = new Vector2(_dimensionTileFloor, _sizeOfScreenHeight / 2 - _offsetCameraY);
            Vector2 positionMapTile = new Vector2(-_sizeOfScreenWidth / 2, -_sizeOfScreenHeight / 4 + _offsetCameraY / 2);
            _spriteRendererFloor.GetComponent<SpriteRenderer>().size = sizeMapTile;
            _spriteRendererFloor.transform.position = positionMapTile;      
            GameObject newObject = Instantiate(_spriteRendererFloor, new Vector2(_spriteRendererFloor.transform.position.x, _spriteRendererFloor.transform.position.y), _spriteRendererFloor.transform.rotation, _trackParent.transform);
            newObject.AddComponent<BoxCollider2D>();
            newObject.GetComponent<BoxCollider2D>().size = sizeMapTile;
            newObject.GetComponent<BoxCollider2D>().transform.position = positionMapTile;
            _floorTilesList.Add(newObject);
            AddInitialElementLevel((int)(_sizeOfScreenWidth / _dimensionTileFloor) + 3, LevelElement.Floor);
        }

        private void InstantiateBackgroundObject()
        {
            _dimensionTileBackground = _spriteRendererBackground.GetComponent<SpriteRenderer>().bounds.extents.x * 2;
            _spriteRendererBackground.GetComponent<SpriteRenderer>().size = new Vector2(_dimensionTileBackground, _sizeOfScreenHeight);
            _spriteRendererBackground.transform.position = new Vector2(-_sizeOfScreenWidth / 2, _offsetCameraY);
            GameObject newObject = Instantiate(_spriteRendererBackground, new Vector2(_spriteRendererBackground.transform.position.x, _spriteRendererBackground.transform.position.y), _spriteRendererBackground.transform.rotation, _trackParent.transform);
            _backgroundTilesList.Add(newObject);
            AddInitialElementLevel((int)(_sizeOfScreenWidth / _dimensionTileBackground) + 3, LevelElement.Background);
        }

        private void InstantiateCeilingObject()
        {
            _dimensionTileCeiling = _spriteRendererCeiling.GetComponent<SpriteRenderer>().bounds.extents.x * 2;
            _spriteRendererCeiling.GetComponent<SpriteRenderer>().size = new Vector2(_dimensionTileCeiling, _sizeOfScreenHeight / 2 - _distanceBetweenCeilingFloor + _offsetCameraY);
            _spriteRendererCeiling.transform.position = new Vector2(-_sizeOfScreenWidth / 2, _sizeOfScreenHeight / 4 + _offsetCameraY / 2 + _distanceBetweenCeilingFloor / 2);
            GameObject newObject = Instantiate(_spriteRendererCeiling, new Vector2(_spriteRendererCeiling.transform.position.x, _spriteRendererCeiling.transform.position.y), _spriteRendererCeiling.transform.rotation, _trackParent.transform);
            _ceilingTilesList.Add(newObject);
            AddInitialElementLevel((int)(_sizeOfScreenWidth / _dimensionTileCeiling) + 3, LevelElement.Ceiling);
        }

        private void InstantiateDeathZoneAndLimitRightZone()
        {
            var dimensionDeathZone = _spriteRendererDeathZone.GetComponent<SpriteRenderer>().bounds.extents.x * 2;
            _spriteRendererDeathZone.GetComponent<SpriteRenderer>().size = new Vector2(dimensionDeathZone, _sizeOfScreenHeight);
            _spriteRendererDeathZone = Instantiate(_spriteRendererDeathZone, new Vector3((float)(_mainCamera.transform.position.x - _sizeOfScreenWidth / 2), _offsetCameraY), Quaternion.identity, _trackParent.transform);
            _spriteRendererDeathZone.AddComponent<BoxCollider2D>();
            _spriteRendererDeathZone.GetComponent<BoxCollider2D>().size = new Vector2(dimensionDeathZone - 0.3f, _sizeOfScreenHeight);
            _spriteRendererDeathZone.AddComponent<DeathZoneEffects>();
            _spriteRendererDeathZone.AddComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic;

            _limitRightZone = Instantiate(_limitRightZonePrefab, _trackParent.transform);
            BoxCollider2D boxCollider2D = _limitRightZone.GetComponent<BoxCollider2D>();
            boxCollider2D.size = new Vector2(2, _sizeOfScreenHeight);
            boxCollider2D.transform.position = new Vector3((float)(_mainCamera.transform.position.x + _sizeOfScreenWidth / 2 + boxCollider2D.size.x / 2), _offsetCameraY);
        }

        private void AddInitialElementLevel(int nrOfTiles, LevelElement levelElement)
        {
            switch (levelElement)
            {
                case LevelElement.Ceiling:
                    for (int i = 0; i < nrOfTiles; i++)
                        AddElementTile(_ceilingTilesList, _dimensionTileCeiling, levelElement);
                    break;
                case LevelElement.Background:
                    for (int i = 0; i < nrOfTiles; i++)
                        AddElementTile(_backgroundTilesList, _dimensionTileBackground, levelElement);
                    break;
                case LevelElement.Floor:
                    for (int i = 0; i < nrOfTiles; i++)
                        AddElementTile(_floorTilesList, _dimensionTileFloor, levelElement);
                    break;
            }
        }

        private void AddElementTile(List<GameObject> list, float dimensionTile, LevelElement levelElement)
        {
            GameObject lastElementOfList = list[list.Count - 1];
            GameObject newMapTile = Instantiate(lastElementOfList, new Vector2(lastElementOfList.transform.position.x + dimensionTile, lastElementOfList.transform.position.y), lastElementOfList.transform.rotation, _trackParent.transform);
            newMapTile.name = levelElement.ToString();
            //add the new object created in the list
            list.Add(newMapTile);
        }

        private void ChangePositionTile(List<GameObject> list, float dimensionTile)
        {
            GameObject firstElementOfList = list[0];
            GameObject lastElementOfList = list[list.Count - 1];
            //change the position of the first element: transform the first element in the last element of the list
            firstElementOfList.transform.position = new Vector2(lastElementOfList.transform.position.x + dimensionTile, lastElementOfList.transform.position.y);
            list.RemoveAt(0);
            list.Add(firstElementOfList);
        }
        #endregion
    }
}
