//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace EndlessRunnerSpine.LevelTrack
{
    [CreateAssetMenu(fileName = "LevelTrack", menuName = "Endless Runner Spine/Level Track Data", order = 0)]
    public class LevelTrackData : ScriptableObject
    {
        #region Private Variables
        [SerializeField]
        private double _speedTrack; //the speed at which a new level set (ceiling, background, floor) will be instantiated

        [SerializeField]
        private GameObject _ceilingType; //the ceiling prefab

        [SerializeField]
        private GameObject _floorType; //the floor prefab

        [SerializeField]
        private GameObject _backgroundType; //the background prefab

        [SerializeField]
        private GameObject _deathZone; //the limit death zone prefab

        [SerializeField]
        private double _screenSpace; //represents the distance of the camera relative to the track, bigger distance => bigger track visible

        [SerializeField]
        private double _distanceBetweenCeilingFloor; //the distance between ceiling and floor, this can be modified whenever "_screenSpace" is modified in order to improve UX
        #endregion

        #region Public Properties
        public double SpeedTrack
        {
            get
            {
                return _speedTrack;
            }

            set
            {
                _speedTrack = value;
            }
        }

        public GameObject CeilingType
        {
            get
            {
                return _ceilingType;
            }
        }

        public GameObject DeathZone
        {
            get
            {
                return _deathZone;
            }
        }

        public GameObject FloorType
        {
            get
            {
                return _floorType;
            }
        }

        public GameObject BackgroundType
        {
            get
            {
                return _backgroundType;
            }
        }

        public double ScreenSpace
        {
            get
            {
                return _screenSpace;
            }
        }

        public double DistanceBetweenCeilingFloor
        {
            get
            {
                return _distanceBetweenCeilingFloor;
            }
        }
        #endregion
    }
}
