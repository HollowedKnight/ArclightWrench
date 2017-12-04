using Source.Simulation.Logic.View;

public class ViewFeature : Feature
{
    public ViewFeature(Contexts contexts) : base("ViewSystems")
    {
        Add(new CreateViewSystem(contexts));
    }
}