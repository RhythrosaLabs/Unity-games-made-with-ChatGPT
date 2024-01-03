
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2.0f;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        // Destroy enemy if it goes off screen
        if (transform.position.x < -Screen.width / 2)
        {
            Destroy(gameObject);
        }
    }
}

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2.0f;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    void SpawnEnemy()
    {
        float spawnY = Random.Range(-Screen.height / 2, Screen.height / 2);
        Instantiate(enemyPrefab, new Vector3(Screen.width / 2, spawnY, 0), Quaternion.identity);
    }
}
