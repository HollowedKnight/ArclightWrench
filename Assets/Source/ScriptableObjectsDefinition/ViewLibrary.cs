using System.Collections.Generic;
using UnityEngine;

namespace Source.ScriptableObjects
{
    [CreateAssetMenu]
    public class ViewLibrary : ScriptableObject
    {
        public GameObject Map;
        public Dictionary<string, GameObject> Views;
        
    }
}
