//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using UnityEngine;

namespace EndlessRunnerSpine.GameProgress
{
    [CreateAssetMenu(fileName = "GameProgress", menuName = "Endless Runner Spine/Game Progress Data", order = 4)]
    public class GameProgressData : ScriptableObject
    {
        #region Private Variables
        [SerializeField]
        private double _currentScore;
        private bool _gameOver = false;
        private bool _LevelRoundFinished = false;
        #endregion

        #region Public Properties
        public double CurrentScore //represents the current score, changing constantly during the level round
        {
            get
            {
                return _currentScore;
            }

            set
            {
                _currentScore = value;
            }
        }
        public bool GameOver //it triggers when the player died
        {
            get => _gameOver;
            set => _gameOver = value;
        }
        public bool LevelRoundFinished //it triggers when a normal level round has been completed
        {
            get => _LevelRoundFinished;
            set => _LevelRoundFinished = value;
        }
        #endregion
    }
}
