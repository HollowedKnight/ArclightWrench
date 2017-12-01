using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class SpawnActorSystem : ReactiveSystem<GameEntity>
{
    public SpawnActorSystem(Contexts contexts) : base(contexts.game)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.SpawnActorCommand);
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.isSpawnActorCommand;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        Debug.Log("I spawn stuff");
    }
}