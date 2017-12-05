namespace ArclightWrench.Simulation.Logic.Game
{
    public class GameFeature : Feature
    {
        public GameFeature(Contexts contexts) : base("GameSystems")
        {
            Add(new CreateActorSystem(contexts));
        }
    }
}