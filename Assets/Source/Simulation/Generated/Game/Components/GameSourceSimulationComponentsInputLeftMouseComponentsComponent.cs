//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly Source.Simulation.Components.Input.LeftMouseComponents sourceSimulationComponentsInputLeftMouseComponentsComponent = new Source.Simulation.Components.Input.LeftMouseComponents();

    public bool isSourceSimulationComponentsInputLeftMouseComponents {
        get { return HasComponent(GameComponentsLookup.SourceSimulationComponentsInputLeftMouseComponents); }
        set {
            if (value != isSourceSimulationComponentsInputLeftMouseComponents) {
                var index = GameComponentsLookup.SourceSimulationComponentsInputLeftMouseComponents;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : sourceSimulationComponentsInputLeftMouseComponentsComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherSourceSimulationComponentsInputLeftMouseComponents;

    public static Entitas.IMatcher<GameEntity> SourceSimulationComponentsInputLeftMouseComponents {
        get {
            if (_matcherSourceSimulationComponentsInputLeftMouseComponents == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.SourceSimulationComponentsInputLeftMouseComponents);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherSourceSimulationComponentsInputLeftMouseComponents = matcher;
            }

            return _matcherSourceSimulationComponentsInputLeftMouseComponents;
        }
    }
}