using System.Collections.Generic;
using Source.CustomTypes;
using UnityEngine;

namespace Source.ScriptableObjectsDefinition
{
    [CreateAssetMenu(menuName = "ScriptableObjects/ViewLibrary")]
    public class ViewLibrary : ScriptableObject
    {
        public List<Actor> Views = new List<Actor>();
    }
}
