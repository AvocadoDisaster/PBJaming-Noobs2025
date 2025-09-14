using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime = 60f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        if (elapsedTime > 0f)
        {
            elapsedTime -= Time.deltaTime;   
        }
        int intElapsedTime = (int)elapsedTime;
        timerText.text = intElapsedTime.ToString();
    }
}
