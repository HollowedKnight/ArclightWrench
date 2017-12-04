﻿using System.Collections.Generic;
using Entitas;
 using UnityEngine;

namespace Source.Simulation.Logic.View
{
    public class CreateViewSystem : ReactiveSystem<ViewEntity>
    {
        private readonly ViewContext _viewContext;

        public CreateViewSystem(Contexts contexts) : base(contexts.view)
        {
            _viewContext = contexts.view;
        }

        protected override ICollector<ViewEntity> GetTrigger(IContext<ViewEntity> context)
        {
            return context.CreateCollector(ViewMatcher.Actor);
        }

        protected override bool Filter(ViewEntity entity)
        {
            return entity.hasActor && !entity.hasView;
        }

        protected override void Execute(List<ViewEntity> entities)
        {
            for (int i = 0; i < entities.Count; i++)
            {
                var entity = entities[i];
                entity.view.Value = GameObject.Instantiate(entity.actor.Value.Prefab);
            }
        }
    }
}