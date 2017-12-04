using Source.CustomTypes;
using UnityEngine;

namespace Source.ScriptableObjectsDefinition
{
    [CreateAssetMenu(menuName = "ScriptableObjects/Actor")]
    public class Actor : ScriptableObject
    {
        [SerializeField]
        private EActor _id;
        
        [SerializeField]
        private GameObject _prefab;

        public GameObject Prefab {
            get { return _prefab; }
        }
    }
}