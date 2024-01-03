
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy") || other.CompareTag("Obstacle"))
        {
            // Handle collision with enemy or obstacle
        }
        else if (other.CompareTag("PowerUp"))
        {
            // Handle collecting a power-up
        }
    }
}
