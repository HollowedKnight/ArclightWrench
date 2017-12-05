using Entitas;
using UnityEngine;

namespace ArclightWrench.Simulation.Logic.Input
{
    public class MouseInputHandlerSystem : IExecuteSystem
    {
        private readonly GameContext _gameContext;

        public MouseInputHandlerSystem(Contexts contexts)
        {
            _gameContext = contexts.game;
        }

        public void Execute()
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(UnityEngine.Input.mousePosition);
            if (UnityEngine.Input.GetMouseButtonDown(0))
            {
                GameEntity entity = _gameContext.CreateEntity();
                entity.isSpawnActorCommand = true;
                entity.AddPosition(mousePosition);
            }
        }
    }
}