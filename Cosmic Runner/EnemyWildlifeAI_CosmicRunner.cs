
using UnityEngine;

public class EnemyWildlifeAI : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float patrolSpeed = 2f;
    public float chaseSpeed = 5f;
    private int currentPointIndex = 0;
    private bool isChasing = false;

    void Update()
    {
        if (isChasing)
        {
            // Add chase logic here
        }
        else
        {
            // Patrol logic
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, patrolSpeed * Time.deltaTime);

            // Switch to the next patrol point
            if (Vector2.Distance(transform.position, patrolPoints[currentPointIndex].position) < 0.1f)
            {
                currentPointIndex = (currentPointIndex + 1) % patrolPoints.Length;
            }
        }
    }

    // Add more complex detection and chase logic here
}
