using UnityEngine;

public class LavaScript : MonoBehaviour
{
    Timer lavaTimerScript;  
    public float riseSpeed = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lavaTimerScript = GameObject.FindGameObjectWithTag("LavaTimer").GetComponent<Timer>();
        //transform.position = new Vector3(100f, lavaPosition, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (lavaTimerScript.ReturnTimer())
        {
            transform.position = transform.position + new Vector3(0f, riseSpeed, 0f) * Time.deltaTime;
        }
    }
}
