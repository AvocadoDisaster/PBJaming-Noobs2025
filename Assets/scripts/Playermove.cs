using System.Runtime.CompilerServices;

using UnityEngine;


public class Playermove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpPower;
    public Rigidbody2D rb;
    private BoxCollider2D boxCollider;
    [SerializeField] private LayerMask groundLayer;
    
    private Animator animator;
    public bool Isgrounded;

    private void Awake()
    {
        //grab refrences
        rb = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector2(horizontalInput * speed, rb.linearVelocityY);

        //flip the player when moving left-right
        if (horizontalInput > 0.01f)
        {
            transform.localScale = Vector3.one;
        }
        else if (horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        // jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        //adjustable jump height
        if( Input.GetKeyUp(KeyCode.Space) && rb.linearVelocityY > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, rb.linearVelocityY/2);
        }
        animator.SetBool("grounded", Isgrounded);

    }

   

        private void Jump()
        {
             if (isGrounded())
            {
                rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpPower);
            // add sound here
            }
             Isgrounded = false;
        animator.SetTrigger("Jump");
        }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isGrounded())
        {
            Isgrounded = true;
        }
    }
    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center,boxCollider.bounds.size, 0, Vector2.down,  0.1f, groundLayer);
        return raycastHit.collider != null;
    }
    
}

