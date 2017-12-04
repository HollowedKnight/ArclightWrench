using Source.ScriptableObjectsDefinition;
using UnityEngine;

namespace Source.Components
{
    public class GameEventDispatcher : MonoBehaviour
    {
        [SerializeField]
        private ActorGameEvent _gameEvent;

        public void Dispatch()
        {
            _gameEvent.Raise();
        }
    }
}