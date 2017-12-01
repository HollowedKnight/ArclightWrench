public class InputSystems : Feature
{
    public InputSystems(Contexts contexts) : base("InputSystems")
    {
        Add(new MouseInputSystem(contexts));
    }
}