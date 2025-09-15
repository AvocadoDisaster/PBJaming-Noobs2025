using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public Collider2D collder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collder = GetComponent<Collider2D>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (collder)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
