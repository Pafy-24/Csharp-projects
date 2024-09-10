//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using UnityEngine;
using UnityEditor;
using EndlessRunnerSpine.Utils.Interval;

namespace EndlessRunnerSpine.LevelObstacles
{
    [CustomEditor(typeof(LevelObstaclesData), true)]
    public class LevelObstaclesDataEditor : Editor
    {
        #region Private Variables
        private LevelObstaclesData _target = default;
        private GUIStyle _titleStyle = default;
        private SerializedObject serializedObject;
        #endregion

        #region Unity Editor Methods
        public void OnEnable()
        {
            _target = target as LevelObstaclesData;
        }

        public override void OnInspectorGUI()
        {
            _titleStyle = new GUIStyle(GUI.skin.label)
            {
                alignment = TextAnchor.MiddleCenter,
                fontSize = 20,
                fontStyle = FontStyle.Bold,
            };

            EditorGUILayout.LabelField("Level Obstacles Data", _titleStyle, GUILayout.Height(40.0f));

            serializedObject = new SerializedObject(_target);
            SerializedProperty spawnRateProperty = serializedObject.FindProperty("_spawnRateCrate");
            spawnRateProperty.doubleValue = EditorGUILayout.DoubleField("Spawn Rate Crate:", spawnRateProperty.doubleValue);

            SerializedProperty spawnRateHGZoneProperty = serializedObject.FindProperty("_spawnRateHGZone");
            spawnRateHGZoneProperty.doubleValue = EditorGUILayout.DoubleField("Spawn HG Zone: ", spawnRateHGZoneProperty.doubleValue);

            SerializedProperty crateSprite = serializedObject.FindProperty("_crate");
            EditorGUILayout.PropertyField(crateSprite);

            SerializedProperty _hgZoneVisual = serializedObject.FindProperty("_hgZone");
            EditorGUILayout.PropertyField(_hgZoneVisual);

            serializedObject.ApplyModifiedProperties();

            IntervalEditor("HG Zone Dimension - Interval", _target.HGZoneDimension, min: 0, max: 100);

            IntervalEditor("Prioritization Obstacles Type", _target.PrioritizationObstaclesType, min: 0, max: 100);
            EditorUtility.SetDirty(target);
        }

        private void IntervalEditor(string textLabel, FloatInterval interval, int min, int max)
        {
            string requiredToBeChoosed = textLabel + "  [" + ((int)interval._min).ToString() + " : " + ((int)interval._max).ToString() + "]";
            EditorGUILayout.MinMaxSlider(new GUIContent(requiredToBeChoosed), ref interval._min, ref interval._max, min, max);
        }
        #endregion
    }
}
