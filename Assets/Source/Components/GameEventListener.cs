using Source.ScriptableObjectsDefinition;
using UnityEngine;
using UnityEngine.Events;

namespace Source.Components
{
    public abstract class GameEventListener<T, TEvent, TUnityEvent> : MonoBehaviour, IEventListener where TEvent : GameEvent<T> where TUnityEvent : UnityEvent<T>
    {
        public TEvent Reference;
        public TUnityEvent Event;

        private void OnEnable()
        {
            Reference.RegisterListener(this);
        }
        
        private void OnDisable()
        {
            Reference.UnregisterEventListener(this);
        }

        public void OnEventRaised()
        {
            Event.Invoke(Reference.Value);
        }
    }
}