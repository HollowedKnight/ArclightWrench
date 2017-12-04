using System.Collections.Generic;
using Entitas;
using Source.ScriptableObjectsDefinition;
using UnityEngine;

public class CreateActorSystem : ReactiveSystem<GameEntity>
{
    private readonly GameContext _gameContext;

    public CreateActorSystem(Contexts contexts) : base(contexts.game)
    {
        _gameContext = contexts.game;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(Matcher<GameEntity>.AllOf(GameMatcher.SpawnActorCommand, GameMatcher.Position));
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isSpawnActorCommand && entity.hasPosition;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        for (int i = 0; i < entities.Count; i++)
        {
            var entity = entities[i];
            GameEntity actorEntity = _gameContext.CreateEntity();
            actorEntity.AddPosition(entity.position.Value);
        }
    }
}