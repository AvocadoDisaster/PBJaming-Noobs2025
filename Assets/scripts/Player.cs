using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    public float moveSpeed = 5f;

    float horizontalMovement;

    void Update()
    {
        rb.linearVelocity = new Vector2(horizontalMovement * moveSpeed,  rb.linearVelocityY);
    }
    public void Move(InputAction.CallbackContext context)
    {
        horizontalMovement = context.ReadValue<Vector2>().x;
    }
}
