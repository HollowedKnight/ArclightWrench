using System.Collections.Generic;
using Source.Components;
using UnityEngine;

namespace Source.ScriptableObjectsDefinition
{
    public class GameEvent<T> : ScriptableObject
    {
        public T Value;

        private List<IEventListener> _listeners = new List<IEventListener>();
        
        public void Raise()
        {
            for (int i = _listeners.Count -1; i >= 0; i--)
            {
                _listeners[i].OnEventRaised();                
            }
        }

        public void RegisterListener(IEventListener listener)
        {
            _listeners.Add(listener);
        }

        public void UnregisterEventListener(IEventListener listener)
        {
            _listeners.Remove(listener);
        }
    }
}