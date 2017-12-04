using Source.ScriptableObjectsDefinition;
using UnityEngine;

namespace Source.Simulation
{
    public class ViewController : MonoBehaviour
    {
        public void CreateActor(Actor actor)
        {
            Instantiate(actor.Prefab);
        }
    }
}