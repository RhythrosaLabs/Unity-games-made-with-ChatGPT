
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int lives = 3;
    public Text scoreText;
    public Text livesText;

    void UpdateScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    void UpdateLives(int change)
    {
        lives += change;
        livesText.text = "Lives: " + lives;

        if (lives <= 0)
        {
            // Handle game over
        }
    }
}
