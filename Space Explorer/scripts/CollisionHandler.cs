
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Asteroid"))
        {
            gameManager.GameOver();
            Destroy(gameObject);
        }

        if (other.gameObject.CompareTag("Star"))
        {
            gameManager.IncreaseScore(10);
            Destroy(other.gameObject);
        }
    }
}
