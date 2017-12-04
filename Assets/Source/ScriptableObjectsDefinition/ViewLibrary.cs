using System.Collections.Generic;
using UnityEngine;

namespace Source.ScriptableObjectsDefinition
{
    [CreateAssetMenu]
    public class ViewLibrary : ScriptableObject
    {
        public GameObject Map;
        public Dictionary<string, GameObject> Views;
        
    }
}
