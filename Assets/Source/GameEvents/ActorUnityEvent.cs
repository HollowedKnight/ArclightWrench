using System;
using Source.ScriptableObjectsDefinition;
using UnityEngine.Events;

namespace Source.GameEvents
{
    [Serializable]
    public class ActorUnityEvent: UnityEvent<Actor>
    {
    }
}