using Source.ScriptableObjectsDefinition;
using UnityEngine;
using UnityEngine.Events;

namespace Source.Components
{
    public abstract class GenericGameEventListener<T, TEvent, TUnityEvent> : MonoBehaviour where TEvent : TypeReference<T> where TUnityEvent : UnityEvent<T>
    {
        public TEvent Reference;
        public TUnityEvent Event;
    }
}