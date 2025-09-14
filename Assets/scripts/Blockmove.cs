using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class Blockmove : MonoBehaviour
{
    public Rigidbody2D blockBody;
    public float speed;
    public Collider2D Collider2D;
    [SerializeField] private LayerMask Wall;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        blockBody = GetComponent<Rigidbody2D>();
        Collider2D = GetComponent<Collider2D>();
    }

    private void Awake()
    {
        blockBody = GetComponent<Rigidbody2D>();
        Collider2D = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        blockBody.linearVelocity = new Vector2(horizontalInput * speed, verticalInput * speed);




    private bool hitwall()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(Collider2D.bounds.center, Collider2D.bounds.size, 0, Vector2.down, 0.1f, Wall);
        return raycastHit.collider != null;


    }
}