using UnityEngine;

public class onload : MonoBehaviour
{
    public GameObject player;
        public GameObject  telekenisis;
    public GameObject moveblock;
        public GameObject map;
    public GameObject eventing;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onload.Instantiate(player);
        onload.Instantiate(telekenisis);
        onload.Instantiate(map);
        onload.Instantiate(moveblock);
        onload.Instantiate(eventing);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
