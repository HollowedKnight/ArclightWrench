public class GameSystems : Feature
{
    public GameSystems(Contexts contexts) : base("GameSystems")
    {
        Add(new SpawnActorSystem(contexts));
    }
}