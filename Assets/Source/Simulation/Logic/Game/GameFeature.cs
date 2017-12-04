using Source.ScriptableObjectsDefinition;
using UnityEngine;

public class GameFeature : Feature
{
    public GameFeature(Contexts contexts) : base("GameSystems")
    {
        Add(new CreateActorSystem(contexts));
    }
}