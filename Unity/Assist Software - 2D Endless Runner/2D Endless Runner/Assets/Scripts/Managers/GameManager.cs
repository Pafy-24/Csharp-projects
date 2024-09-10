//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using EndlessRunnerSpine.GameProgress;
using EndlessRunnerSpine.Enums;
using EndlessRunnerSpine.Utils;
using UnityEngine.SceneManagement;
using System.Collections;

namespace EndlessRunnerSpine
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;

        #region Private Variables
        [SerializeField]
        private List<LevelData> _levelData = new List<LevelData>();

        [SerializeField]
        private GameProgressData _gameProgress;

        private double _bonusScoreKill = 10;
        private PlayerProgress _playerProgress;
        private AsyncOperation _loadScene;
        #endregion

        #region Const Members
        private const string kJsonFileName = "/PlayerProgress.json";
        #endregion

        #region Public Properties
        public static GameManager Instance { get => instance; }
        public GameMode GameType { get; set; } = GameMode.Endless;
        public int CurrentIndexLevel { get; private set; } = 0;
        public bool GameOver { get; set; } = false;
        public List<LevelData> LevelDataList { get => _levelData; }
        public GameProgressData GameProgress { get => _gameProgress; }
        public double BestScore { get => _playerProgress._bestScores[CurrentIndexLevel]; }
        #endregion

        #region Public Variables
        public delegate void OnInitializeLevel(LevelData levelData);
        public static OnInitializeLevel onInitializeLevel;
        #endregion

        #region Unity Methods
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            LoadGameProgress();
            StartLevel(CurrentIndexLevel);
        }

        private void Update()
        {
            if (GameOver == false)
            {
                IncrementScore();
            }
        }
        #endregion

        #region Public Methods
        public void StartLevel(int index)
        {
            SetCurrentLevelIndex(index);
            InitializeLevel();
        }

        public void RestartScene()
        {
            _loadScene = SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
            _loadScene.completed += OnSceneLoaded();
        }

        public void AddBonusScore()
        {
            _gameProgress.CurrentScore += _bonusScoreKill;
        }

        public void LoadGameProgress()
        {
            if (File.Exists(Application.persistentDataPath + kJsonFileName) == true)
            {
                var jsonString = File.ReadAllText(Application.persistentDataPath + kJsonFileName);
                _playerProgress = JsonUtility.FromJson<PlayerProgress>(jsonString);

                bool less = _playerProgress._bestScores.Length < _levelData.Count;

                if (_playerProgress._bestScores.Length != _levelData.Count)
                {
                    double[] scores = _playerProgress._bestScores;
                    _playerProgress._bestScores = new double[_levelData.Count];

                    for (int i = 0; i <= (less ? scores.Length : _levelData.Count); i++)
                    {
                        _playerProgress._bestScores[i] = scores[i];
                    }
                }
            }
            else
            {
                CreateJsonFile();
            }
        }

        public void OnGameOver()
        {
            if (_gameProgress.CurrentScore > _playerProgress._bestScores[CurrentIndexLevel])
            {
                _playerProgress._bestScores[CurrentIndexLevel] = _gameProgress.CurrentScore;
                Save();
            }
        }

        public void Save()
        {
            var jsonString = JsonUtility.ToJson(_playerProgress);
            File.WriteAllText(Application.persistentDataPath + kJsonFileName, jsonString);
        }
        #endregion

        #region Private Methods
        private void SetCurrentLevelIndex(int index)
        {
            CurrentIndexLevel = index;
        }

        private Action<AsyncOperation> OnSceneLoaded()
        {
            StartCoroutine(DelayedInitializeLevel());
            return null;
        }

        private IEnumerator DelayedInitializeLevel()
        {
            yield return new WaitForSeconds(0.05f);
            InitializeLevel();
        }

        private void InitializeLevel()
        {
            GameOver = false;
            _gameProgress.CurrentScore = 0;
            onInitializeLevel?.Invoke(_levelData[CurrentIndexLevel]);
        }

        private void IncrementScore()
        {
            _gameProgress.CurrentScore += Time.deltaTime;
        }

        private void CreateJsonFile()
        {
            _playerProgress = new PlayerProgress();
            _playerProgress._bestScores = new double[_levelData.Count];

            var jsonString = JsonUtility.ToJson(_playerProgress);
            File.WriteAllText(Application.persistentDataPath + kJsonFileName, jsonString);
        }
        #endregion
    }
}
