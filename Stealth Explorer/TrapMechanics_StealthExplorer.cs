
using UnityEngine;

public class TrapMechanics : MonoBehaviour
{
    // Example method for activating a trap
    public void ActivateTrap()
    {
        // Add logic for trap activation and its effects on player and enemies
    }

    // Example method for detecting if an entity triggers the trap
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Enemy"))
        {
            ActivateTrap();
        }
    }
}
