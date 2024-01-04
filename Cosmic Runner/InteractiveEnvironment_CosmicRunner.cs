
using UnityEngine;

public class InteractiveEnvironment : MonoBehaviour
{
    // Example method for interacting with the environment
    public void InteractWithEnvironment(GameObject environmentObject)
    {
        // Add logic for different types of environmental interactions
    }

    // Example of a triggered interaction
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Trigger an environmental interaction
            InteractWithEnvironment(other.gameObject);
        }
    }
}
