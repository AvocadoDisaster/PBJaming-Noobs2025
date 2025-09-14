using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class BoxMovment : MonoBehaviour
{
    public GameObject TelekeneticBlock;
    [SerializeField] private float speed;
    public Transform TelekeneticCheck;
    public float TelekeneticRadius = 10f;
    public LayerMask TelekeneticLayerMask;
    public Rigidbody2D blockBody;
    public Rigidbody2D rb;

    public bool telekenticmode = false;

    public bool IsTelekenetic = false;



    private void Start()
    {
        blockBody = TelekeneticBlock.GetComponent<Rigidbody2D>();
        rb = gameObject.GetComponent<Rigidbody2D>();

        


    }
    void FixedUpdate()
    {
        Collider2D TelekeneticCollider = Physics2D.OverlapCircle(TelekeneticCheck.position, TelekeneticRadius, TelekeneticLayerMask);
        IsTelekenetic = TelekeneticCollider != null ? true : false;

        if (IsTelekenetic == true && Input.GetKeyDown(KeyCode.J))
        {
            
            telekenticmode = true;
            while (telekenticmode)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    blockBody.linearVelocity = new Vector2(speed, 0);
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    blockBody.linearVelocity = new Vector2(-speed, 0);
                }
                else if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    blockBody.linearVelocity = new Vector2(0, speed);
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    blockBody.linearVelocity = new Vector2(0, -speed);
                }
                else { blockBody.linearVelocity = new Vector2(0, 0); }
                
            }
            

           

            
        }
        else if (IsTelekenetic == true && Input.GetKeyDown(KeyCode.J) || IsTelekenetic == false && Input.GetKeyDown(KeyCode.J))
        {
            
            telekenticmode = false;
            
        }

    }

    void isTelekenetic()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(TelekeneticCheck.position,TelekeneticRadius);
    }


}
