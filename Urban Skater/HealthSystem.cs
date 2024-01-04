
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public int health = 3;
    public Text healthText;

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthText.text = "Health: " + health.ToString();
        
        if (health <= 0)
        {
            // Implement game over logic
            Debug.Log("Game Over");
        }
    }
}
