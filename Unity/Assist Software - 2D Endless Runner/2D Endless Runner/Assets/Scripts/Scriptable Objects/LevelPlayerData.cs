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
using EndlessRunnerSpine.Enums;

namespace EndlessRunnerSpine.LevelPlayer
{
    [CreateAssetMenu(fileName = "LevelPlayer", menuName = "Endless Runner Spine/Level Player Data", order = 3)]
    public class LevelPlayerData : ScriptableObject
    {
        #region Private Variables
        [SerializeField]
        private double _accelerationPlayer; //the speed acceleration of the player

        [SerializeField]
        private WeaponType _weaponTypePlayer; // the weapon type of the player (skeleton part of the player)

        [SerializeField]
        private double _impulseForce; // the impulse force of an jump
        #endregion

        #region Public Properties
        public double AccelerationPlayer
        {
            get
            {
                return _accelerationPlayer;
            }
        }
        public WeaponType WeaponTypePlayer
        {
            get
            {
                return _weaponTypePlayer;
            }
        }

        public double ImpulseForce
        {
            get
            {
                return _impulseForce;
            }
        }
        #endregion
    }
}
    
