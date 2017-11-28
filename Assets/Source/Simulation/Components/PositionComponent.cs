using Entitas;
using UnityEngine;

namespace Source.Simulation.Components
{
    [Game]
    public class PositionComponent : IComponent
    {
        public Vector3 Value;
    }
}