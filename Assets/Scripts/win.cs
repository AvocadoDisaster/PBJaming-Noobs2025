using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public string winningTag = "Player";
    public Collider2D collder;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        collder = GetComponent<Collider2D>();
        if (collder != null)
        {
            collder.isTrigger = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (collder)
        {
            SceneManager.LoadScene("Win");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(winningTag))
        {
            // Load the Win scene
            SceneManager.LoadScene("Win");
        }
    }
}
