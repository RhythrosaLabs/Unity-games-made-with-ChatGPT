
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    void Update()
    {
        // Update score based on time or other factors
        score = CalculateScore();
        scoreText.text = "Score: " + score.ToString();
    }

    int CalculateScore()
    {
        // Implement score calculation logic here
        // For example, score can increase over time or based on tricks performed
        return (int)Time.timeSinceLevelLoad * 10; // Example scoring logic
    }
}
