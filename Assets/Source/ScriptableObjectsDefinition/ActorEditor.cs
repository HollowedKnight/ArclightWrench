using UnityEditor;

namespace Source.ScriptableObjectsDefinition
{
    [CustomEditor(typeof(Actor))]
    public class ActorEditor : Editor
    {
        private SerializedProperty _name;
        private SerializedProperty _prefab;

        private void OnEnable()
        {
            _name = serializedObject.FindProperty("_name");
            _prefab = serializedObject.FindProperty("_prefab");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(_name);
            EditorGUILayout.PropertyField(_prefab);
            serializedObject.ApplyModifiedProperties();
        }
    }
}