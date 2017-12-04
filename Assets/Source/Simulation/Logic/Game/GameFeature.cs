public class GameFeature : Feature
{
    public GameFeature(Contexts contexts) : base("GameSystems")
    {
        Add(new SpawnActorSystem(contexts));
    }
}