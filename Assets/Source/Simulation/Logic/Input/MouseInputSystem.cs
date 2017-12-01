using Entitas;
using UnityEngine;

public class MouseInputSystem : IInitializeSystem, IExecuteSystem
{
    private readonly GameContext _gameContext;
    
    public MouseInputSystem(Contexts contexts)
    {
        _gameContext = contexts.game;
    }

    public void Initialize()
    {
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