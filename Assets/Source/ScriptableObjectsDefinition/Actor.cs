using UnityEngine;

namespace Source.ScriptableObjectsDefinition
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Actor")]
    public class Actor : ScriptableObject
    {
        [SerializeField]
        private string _name;
        
        [SerializeField]
        private GameObject _prefab;

        public GameObject Prefab {
            get { return _prefab; }
        }
    }
}