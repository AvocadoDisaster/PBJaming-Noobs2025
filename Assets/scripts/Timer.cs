using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] string loseScene; 
    float elapsedTime = 60f;

    // Update is called once per frame
    void Update()
    {
        int intElapsedTime = Mathf.Max(0, (int)elapsedTime);
        timerText.text = intElapsedTime.ToString();
        if (elapsedTime > 0f)
        {
            elapsedTime -= Time.deltaTime;
        }
        else
        {
            //change to lose scene
            SceneManager.LoadScene(loseScene);
        }
    }

    public bool ReturnTimer()
    {
        if (elapsedTime > 0f)
        {
            return false;
        }
        else
        {
            return true;
        }

    }
}
