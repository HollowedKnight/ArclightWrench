//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class ViewEntity {

    public Source.Simulation.Components.View.ViewComponent sourceSimulationComponentsViewView { get { return (Source.Simulation.Components.View.ViewComponent)GetComponent(ViewComponentsLookup.SourceSimulationComponentsViewView); } }
    public bool hasSourceSimulationComponentsViewView { get { return HasComponent(ViewComponentsLookup.SourceSimulationComponentsViewView); } }

    public void AddSourceSimulationComponentsViewView(UnityEngine.GameObject newGameObject) {
        var index = ViewComponentsLookup.SourceSimulationComponentsViewView;
        var component = CreateComponent<Source.Simulation.Components.View.ViewComponent>(index);
        component.GameObject = newGameObject;
        AddComponent(index, component);
    }

    public void ReplaceSourceSimulationComponentsViewView(UnityEngine.GameObject newGameObject) {
        var index = ViewComponentsLookup.SourceSimulationComponentsViewView;
        var component = CreateComponent<Source.Simulation.Components.View.ViewComponent>(index);
        component.GameObject = newGameObject;
        ReplaceComponent(index, component);
    }

    public void RemoveSourceSimulationComponentsViewView() {
        RemoveComponent(ViewComponentsLookup.SourceSimulationComponentsViewView);
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
public sealed partial class ViewMatcher {

    static Entitas.IMatcher<ViewEntity> _matcherSourceSimulationComponentsViewView;

    public static Entitas.IMatcher<ViewEntity> SourceSimulationComponentsViewView {
        get {
            if (_matcherSourceSimulationComponentsViewView == null) {
                var matcher = (Entitas.Matcher<ViewEntity>)Entitas.Matcher<ViewEntity>.AllOf(ViewComponentsLookup.SourceSimulationComponentsViewView);
                matcher.componentNames = ViewComponentsLookup.componentNames;
                _matcherSourceSimulationComponentsViewView = matcher;
            }

            return _matcherSourceSimulationComponentsViewView;
        }
    }
}