using Entitas;
using Source.ScriptableObjectsDefinition;

namespace ArclightWrench.Simulation.Components.Game
{
    [Game]
    public class ActorComponent : IComponent
    {
        public Actor Value;
    }
}