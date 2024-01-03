
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float boundaryPadding = 0.5f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0) * speed * Time.deltaTime;
        transform.position += movement;

        // Keep the player within the screen boundaries
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -Screen.width/2 + boundaryPadding, Screen.width/2 - boundaryPadding),
            Mathf.Clamp(transform.position.y, -Screen.height/2 + boundaryPadding, Screen.height/2 - boundaryPadding),
            transform.position.z
        );
    }
}
