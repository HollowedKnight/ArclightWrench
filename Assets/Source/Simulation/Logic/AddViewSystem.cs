using System.Collections.Generic;
using Entitas;
using Source.ScriptableObjects;

namespace Source.Simulation.Logic
{
    public class AddViewSystem : ReactiveSystem<GameEntity>
    {
        private readonly GameContext _context;
        public AddViewSystem(Contexts contexts, ViewLibrary lib) : base(contexts.game)
        {
            _context = contexts.game;
        }

        protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
        {
            return context.CreateCollector();
        }

        protected override bool Filter(GameEntity entity)
        {
            return true;
        }

        protected override void Execute(List<GameEntity> entities)
        {
            // TODO 
        }
    }
}