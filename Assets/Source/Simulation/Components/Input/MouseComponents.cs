using Entitas;
using Entitas.CodeGeneration.Attributes;
using UnityEngine;

namespace ArclightWrench.Simulation.Components.Input
{
    [Input]
    [Unique]
    public class LeftMouseComponent : IComponent
    {
    }

    [Input]
    [Unique]
    public class RightMouseComponent : IComponent
    {
    }

    [Input]
    public class MouseDownComponent : IComponent
    {
        public Vector2 position;
    }

    [Input]
    public class MouseUpComponent : IComponent
    {
        public Vector2 position;
    }

    [Input]
    public class MousePositionComponent : IComponent
    {
        public Vector2 position;
    }
}