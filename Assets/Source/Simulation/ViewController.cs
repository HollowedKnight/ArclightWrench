using Source.ScriptableObjectsDefinition;
using UnityEngine;

namespace ArclightWrench.Simulation
{
    public class ViewController : MonoBehaviour
    {
        public void CreateActor(Actor actor)
        {
            Instantiate(actor.Prefab);
        }
    }
}