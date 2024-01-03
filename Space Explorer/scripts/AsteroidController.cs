
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);

        if(transform.position.x < -10)
        {
            Destroy(gameObject);
        }
    }
}
