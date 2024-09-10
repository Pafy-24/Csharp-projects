//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using System;
using UnityEngine;

/// <summary>
/// This class can define an interval of floats
/// </summary>
/// 
namespace EndlessRunnerSpine.Utils.Interval
{
    [Serializable]
    public class FloatInterval
    {
        #region Public Variables
        public float _max;
        public float _min;
        #endregion

        #region Constructors
        public FloatInterval(float min, float max)
        {
            _min = min;
            _max = max;
        }
        #endregion
        
        #region Public Methods
        public bool InRange(float value)
        {
            return (value >= _min && value <= _max);
        }
        #endregion
    }
}
