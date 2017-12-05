using Entitas;
using UnityEngine;

namespace ArclightWrench.Simulation.Components.Game
{
    [Game]
    public class PositionComponent : IComponent
    {
        public Vector2 Value;
    }
}