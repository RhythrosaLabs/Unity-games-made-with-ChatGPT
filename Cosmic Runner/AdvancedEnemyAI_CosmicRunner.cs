
using UnityEngine;

public class AdvancedEnemyAI : MonoBehaviour
{
    public Transform[] patrolPoints;
    public float patrolSpeed = 3f;
    public float chaseSpeed = 6f;
    public float detectionRange = 5f;
    private int currentPointIndex = 0;
    private bool isChasing = false;
    private Transform playerTransform;

    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        if (isChasing)
        {
            // Chase logic
            ChasePlayer();
        }
        else
        {
            // Patrol logic
            Patrol();
        }

        // Detection logic
        DetectPlayer();
    }

    void Patrol()
    {
        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, patrolSpeed * Time.deltaTime);
        if (Vector2.Distance(transform.position, patrolPoints[currentPointIndex].position) < 0.1f)
        {
            currentPointIndex = (currentPointIndex + 1) % patrolPoints.Length;
        }
    }

    void ChasePlayer()
    {
        transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, chaseSpeed * Time.deltaTime);
    }

    void DetectPlayer()
    {
        if (Vector2.Distance(transform.position, playerTransform.position) < detectionRange)
        {
            isChasing = true;
        }
        else
        {
            isChasing = false;
        }
    }
}
