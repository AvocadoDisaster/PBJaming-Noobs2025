using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Telekenisis : MonoBehaviour
{


    public GameObject[] controllables;
    [SerializeField] 
    GameObject currentcontrolled;
    [SerializeField]
    public bool blockMode = false;



    private void Start()
    {
        currentcontrolled = controllables[0].gameObject;
        controllables[1].gameObject.GetComponent<Blockmove>().enabled = false;
    }

    

  

     void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.J) && controllables[0] && blockMode == false)
        {
            
            currentcontrolled = controllables[1].gameObject;
            controllables[0].GetComponent<Playermove>().enabled = false;
            currentcontrolled.GetComponent<Blockmove>().enabled = true;

            blockMode = true;

        }
        else if (Input.GetKeyDown(KeyCode.K) && controllables[1] && blockMode == true)
        {
            
            currentcontrolled = controllables[0].gameObject;
            controllables[0].GetComponent<Playermove>().enabled = true;
            controllables[1].GetComponent<Blockmove>().enabled = false;
            blockMode = false;

        }

        
        
    }



}
