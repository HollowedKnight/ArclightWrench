public class InputFeature : Feature
{
    public InputFeature(Contexts contexts) : base("InputSystems")
    {
        Add(new MouseInputHandlerSystem(contexts));
    }
}