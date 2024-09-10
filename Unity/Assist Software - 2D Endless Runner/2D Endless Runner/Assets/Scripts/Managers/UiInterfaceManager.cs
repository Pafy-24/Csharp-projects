//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using System;
using UnityEngine;
using UnityEngine.UI;
using EndlessRunnerSpine.GameProgress;

namespace EndlessRunnerSpine.UI
{
    public class UiInterfaceManager : MonoBehaviour
    {
        #region Private Variables
        [SerializeField]
        private GameProgressData _gameProgress;

        [SerializeField]
        private Text _currentScoreUI;

        [SerializeField]
        private Text _endGameMessage;

        [SerializeField]
        private Text _bestScoreUIGameOver;

        [SerializeField]
        private Text _bestScoreUI;

        [SerializeField]
        private Text _currentScoreGameOverUI;

        [SerializeField]
        private GameObject _visualUIInGame;

        [SerializeField]
        private GameObject _visualUIInGameOver;

        [SerializeField]
        private Button _buttonRestartLevel;

        private double _previousScore;
        #endregion

        #region Const Members
        private const string kTextBestScore = "Best Score : ";
        private const string kTextCurrentScore = "Current Score : ";
        private const string kGameOverMessage = "Game Over";
        private const string kLevelCompletedMessage = "Level Completed";
        #endregion

        #region Unity Methods
        private void Start()
        {
            _buttonRestartLevel.onClick.AddListener(RestartLevel);

            UpdateUI(GameManager.Instance.GameOver);
        }
        void Update()
        {
            if (_gameProgress != null)
            {
                if (_previousScore != _gameProgress.CurrentScore)
                {
                    UpdateCurrentScoreUI();
                    _previousScore = _gameProgress.CurrentScore;
                }
                UpdateUI(GameManager.Instance.GameOver);
            }
        }
        #endregion

        #region Private Methods
        private void UpdateUI(bool gameOver)
        {
            Cursor.visible = _visualUIInGameOver.activeSelf;

            if (_visualUIInGame.activeSelf == gameOver)
            {
                _visualUIInGame.SetActive(!_visualUIInGame.activeSelf);
                UpdateGameOverScoresUI();
            }

            if (_visualUIInGameOver.activeSelf != gameOver)
            {
                _visualUIInGameOver.SetActive(!_visualUIInGameOver.activeSelf);
            }
        }

        private void RestartLevel()
        {
            GameManager.Instance.RestartScene();
        }

        private void UpdateGameOverScoresUI()
        {
            _endGameMessage.text = (GameManager.Instance.GameProgress.LevelRoundFinished ? kLevelCompletedMessage : kGameOverMessage);
            _currentScoreGameOverUI.text = kTextCurrentScore + Math.Round(_gameProgress.CurrentScore, 1).ToString("F1");

            double currentBestScore = _gameProgress.CurrentScore > GameManager.Instance.BestScore ? _gameProgress.CurrentScore : GameManager.Instance.BestScore;
            _bestScoreUIGameOver.text = kTextBestScore + Math.Round(currentBestScore, 1).ToString("F1");
        }

        private void UpdateCurrentScoreUI()
        {
            _currentScoreUI.text = Math.Round(_gameProgress.CurrentScore, 1).ToString("F1");
            double currentBestScore = _gameProgress.CurrentScore > GameManager.Instance.BestScore ? _gameProgress.CurrentScore : GameManager.Instance.BestScore;
            _bestScoreUI.text = Math.Round(currentBestScore, 1).ToString("F1");
        }
        #endregion
    }
}