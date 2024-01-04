
using UnityEngine;

public class HybridMovement : MonoBehaviour
{
    public float skateSpeed = 10f;
    public float stealthSpeed = 3f;
    public float jumpForce = 15f;
    private Rigidbody2D rb;
    private bool isGrounded;
    private bool inStealthMode = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Toggle stealth mode
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            inStealthMode = !inStealthMode;
        }

        // Movement logic
        float moveInput = Input.GetAxis("Horizontal");
        float speed = inStealthMode ? stealthSpeed : skateSpeed;
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);

        // Jumping
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
