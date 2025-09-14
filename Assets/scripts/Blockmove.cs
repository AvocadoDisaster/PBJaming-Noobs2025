using UnityEngine;

public class Blockmove : MonoBehaviour
{
    public Rigidbody2D blockBody;
    public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        blockBody = GetComponent<Rigidbody2D>();
    }

    private void Awake()
    {
        blockBody= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        blockBody.linearVelocity = new Vector2(horizontalInput * speed, verticalInput * speed);
    }
}
