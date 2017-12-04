using Entitas;
using UnityEngine;

public class MouseInputHandlerSystem : IExecuteSystem
{
    private readonly GameContext _gameContext;

    public MouseInputHandlerSystem(Contexts contexts)
    {
        _gameContext = contexts.game;
    }

    public void Execute()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            GameEntity entity = _gameContext.CreateEntity();
            entity.isSpawnActorCommand = true;
            entity.AddPosition(mousePosition);
        }
    }
}