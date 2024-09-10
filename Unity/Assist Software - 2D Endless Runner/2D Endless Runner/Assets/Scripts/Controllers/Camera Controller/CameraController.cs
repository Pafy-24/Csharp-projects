//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using EndlessRunnerSpine.LevelPlayer;

namespace EndlessRunnerSpine.LevelTrack
{
    public class CameraController : MonoBehaviour
    {
        #region Private Variables
        [SerializeField]
        private GameObject _player;

        private LevelTrackData _levelTrackData;
        private Camera _mainCamera;
        private float _offsetCameraY;
        private double _sizeOfScreenWidth = 0;
        private Vignette _vignette;
        private ChromaticAberration _chromaticAberration;
        #endregion

        #region Unity Methods
        void Awake()
        {
            GameManager.onInitializeLevel += OnInitializeLevel;
            _mainCamera = Camera.main.GetComponent<Camera>();
        }

        void FixedUpdate()
        {
            if (_levelTrackData != null)
            {
                StartChromaticAberrationEffect();
                GameObject player;
                _mainCamera.transform.position = new Vector3(_mainCamera.transform.position.x + (float)_levelTrackData.SpeedTrack * Time.deltaTime, _offsetCameraY, -(float)_levelTrackData.ScreenSpace);
                UpdateVignette();
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
            _player = GameObject.FindWithTag("Player");
            _offsetCameraY = (float)_levelTrackData.DistanceBetweenCeilingFloor / 2;
            _mainCamera.transform.position = new Vector3(0, _offsetCameraY, -(float)_levelTrackData.ScreenSpace);
            _sizeOfScreenWidth = (float)(2.0f * _levelTrackData.ScreenSpace * Mathf.Tan(_mainCamera.fieldOfView * 0.5f * Mathf.Deg2Rad) * _mainCamera.aspect);
            gameObject.GetComponent<PostProcessVolume>().profile.TryGetSettings(out _vignette);
            gameObject.GetComponent<PostProcessVolume>().profile.TryGetSettings(out _chromaticAberration);

        }
        private void UpdateVignette()
        {
            //Implementation code:
            //This method should update the vignette camera effect when the player gets near the death limit zone (left part of the screen)
            //You should modify the "_vignette" member of this class in order to modify the parameters of the camera effect

            if (_player.GetComponent<PlayerController>().IsNearDeathZone >= 0.3d)
                if ((float)_player.GetComponent<PlayerController>().IsNearDeathZone < 0.5f)
                    _vignette.intensity.value = (float)_player.GetComponent<PlayerController>().IsNearDeathZone;
                else
                    _vignette.intensity.value = 0.5f;
            else
                _vignette.intensity.value = 0.3f;
        }
        #endregion

        #region Public Methods
        public IEnumerator StartChromaticAberrationEffect()
        {
            //Implementation code:
            //This method is triggered when the player is inside the HG zone
            //You should modify the "_chromaticAberration" member of this class in order to modify the parameters of the camera effect
            //You should also write the functionality using delays for this coroutine.
            _chromaticAberration.intensity.value = 0.5f;
            yield return null;
        }

        public IEnumerator StopChromaticAberrationEffect()
        {
            //Implementation code:
            //This method is triggered when the player is outside the HG zone
            //You should modify the "_chromaticAberration" member of this class in order to modify the parameters of the camera effect
            //You should also write the functionality using delays for this coroutine.
            _chromaticAberration.intensity.value = 0f;
            yield return null;
        }
        #endregion
    }
}