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

namespace EndlessRunnerSpine.LevelEnemy
{   
    [CustomEditor(typeof(LevelEnemyData), true)]
    public class LevelEnemyDataEditor : Editor
    {
        #region Private Variables
        private LevelEnemyData _target = default;
        
        private GUIStyle _titleStyle = default;

        private SerializedObject serializedObject;
        #endregion

        #region Unity Methods
        public void OnEnable()
        {
            _target = target as LevelEnemyData;
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
            
            EditorGUILayout.LabelField("Level Enemy Data", _titleStyle, GUILayout.Height(40.0f));

            IntervalEditor(_target.Prioritization);
            EditorUtility.SetDirty(_target);

            serializedObject = new SerializedObject(_target);

            var list = serializedObject.FindProperty("_enemies");
            if (GUILayout.Button("Add enemy"))
            {
                list.arraySize += 1;
            }

            if (GUILayout.Button("Remove enemy"))
            {
                list.arraySize -= 1;
            }

            for (int i = 0; i < list.arraySize; i++)
            {
                EditorGUILayout.Space(5);
                EditorGUILayout.LabelField("Enemy ");

                SerializedProperty enemyData = list.GetArrayElementAtIndex(i);

                SerializedProperty skeleton = enemyData.FindPropertyRelative("_skeleton");
                EditorGUILayout.PropertyField(skeleton, true);

                SerializedProperty enemyType = enemyData.FindPropertyRelative("_enemyType");
                EditorGUILayout.PropertyField(enemyType, true);

                EditorGUILayout.Space(5);
            }

            EditorGUILayout.Space(15);

            SerializedProperty _spawnRate = serializedObject.FindProperty("_spawnRate");
            _spawnRate.doubleValue = EditorGUILayout.DoubleField("Spawn Rate: ", _spawnRate.doubleValue);

            serializedObject.ApplyModifiedProperties();
        }

        private void IntervalEditor(FloatInterval interval)
        {
            string requiredToBeChoosed = "Prioritization Enemy Type [" + ((int)interval._min).ToString() + " : " + ((int)interval._max).ToString() + "]";
            EditorGUILayout.MinMaxSlider(new GUIContent(requiredToBeChoosed), ref interval._min, ref interval._max, 0, 100);
        }
        #endregion
    }
}
