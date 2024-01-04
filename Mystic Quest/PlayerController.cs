
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float jumpForce = 10.0f;
    private Rigidbody2D rb;
    private bool isGrounded = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
        if(Input.GetButtonDown("Fire1"))
        {
            CastSpell();
        }
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        Vector2 move = new Vector2(x * speed, rb.velocity.y);
        rb.velocity = move;
    }

    void Jump()
    {
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        isGrounded = false;
    }

    void CastSpell()
    {
        // Spell casting logic here
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
