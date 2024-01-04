
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private HealthSystem healthSystem;

    void Start()
    {
        healthSystem = GetComponent<HealthSystem>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Detect collision with obstacles
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            healthSystem.TakeDamage(1);
        }
    }
}
