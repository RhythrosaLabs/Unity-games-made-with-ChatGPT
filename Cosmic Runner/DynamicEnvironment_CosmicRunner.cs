
using UnityEngine;

public class DynamicEnvironment : MonoBehaviour
{
    // Example method for a dynamic interaction with the environment
    public void Interact(GameObject environmentObject)
    {
        // Add logic for various environmental interactions
        // This could include activating traps, opening secret passages, etc.
    }

    // Example of triggering an interaction upon collision
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Interact(collision.gameObject);
        }
    }
}
