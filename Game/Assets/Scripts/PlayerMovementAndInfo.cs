using UnityEngine;

public class PlayerMovementAndInfo : MonoBehaviour
{
    public Rigidbody2D rb;
    public float playerSpeed;
    Vector2 movement;
    public float point;

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * playerSpeed * Time.fixedDeltaTime);
    }
}
