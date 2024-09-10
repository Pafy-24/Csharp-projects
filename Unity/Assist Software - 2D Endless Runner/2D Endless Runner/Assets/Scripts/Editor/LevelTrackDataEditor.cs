//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using UnityEngine;
using UnityEditor;

namespace EndlessRunnerSpine.LevelTrack
{
    [CustomEditor(typeof(LevelTrackData), true)]
    public class LevelTrackDataEditor : Editor
    {
        #region Private Variables
        private LevelTrackData _target = default;
        private GUIStyle _titleStyle = default;
        private SerializedObject serializedObject;
        #endregion

        #region Unity Editor Methods
        public void OnEnable()
        {
            _target = target as LevelTrackData;
            serializedObject = new SerializedObject(_target);
        }

        public override void OnInspectorGUI()
        {
            _titleStyle = new GUIStyle(GUI.skin.label)
            {
                alignment = TextAnchor.MiddleCenter,
                fontSize = 20,
                fontStyle = FontStyle.Bold,
            };

            EditorGUILayout.LabelField("Level Track Data", _titleStyle, GUILayout.Height(40.0f));

            SerializedProperty trackSpeed = serializedObject.FindProperty("_speedTrack");
            trackSpeed.doubleValue = EditorGUILayout.DoubleField("Speed Track: ", trackSpeed.doubleValue);

            SerializedProperty ceilingType = serializedObject.FindProperty("_ceilingType");
            EditorGUILayout.PropertyField(ceilingType);

            SerializedProperty floorType = serializedObject.FindProperty("_floorType");
            EditorGUILayout.PropertyField(floorType);

            SerializedProperty backgroundType = serializedObject.FindProperty("_backgroundType");
            EditorGUILayout.PropertyField(backgroundType);

            SerializedProperty deathZone = serializedObject.FindProperty("_deathZone");
            EditorGUILayout.PropertyField(deathZone);

            SerializedProperty screenSpace = serializedObject.FindProperty("_screenSpace");
            screenSpace.doubleValue = EditorGUILayout.DoubleField("Screen Space: ", screenSpace.doubleValue);

            SerializedProperty distanceBetweenCeilingFloor = serializedObject.FindProperty("_distanceBetweenCeilingFloor");
            distanceBetweenCeilingFloor.doubleValue = EditorGUILayout.DoubleField("Distance Between Ceiling Floor: ", distanceBetweenCeilingFloor.doubleValue);

            serializedObject.ApplyModifiedProperties();
        }
        #endregion
    }
}

