using UnityEditor;

namespace Source.ScriptableObjectsDefinition
{
    [CustomEditor(typeof(Actor))]
    public class ActorEditor : Editor
    {
        private SerializedProperty _id;
        private SerializedProperty _prefab;

        private void OnEnable()
        {
            _id = serializedObject.FindProperty("_id");
            _prefab = serializedObject.FindProperty("_prefab");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorGUILayout.PropertyField(_id);
            EditorGUILayout.PropertyField(_prefab);
            serializedObject.ApplyModifiedProperties();
        }
    }
}