
using UnityEngine;

public class GameController : MonoBehaviour
{
    public bool isGameActive = true;

    void Start()
    {
        // Initialize game state
    }

    void Update()
    {
        if (isGameActive)
        {
            // Game logic
        }
        else
        {
            // Pause or game over logic
        }
    }
}
