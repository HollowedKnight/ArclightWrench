using Source.Simulation.Logic.View;

public class ViewSystems : Feature
{
    public ViewSystems(Contexts contexts) : base("ViewSystems")
    {
        Add(new CreateViewSystem(contexts));
    }
}