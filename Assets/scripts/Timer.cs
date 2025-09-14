using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    float elapsedTime = 60f;

    // Update is called once per frame
    void Update()
    {
        int intElapsedTime = (int)elapsedTime;
        timerText.text = intElapsedTime.ToString();
        if (elapsedTime > 0f)
        {
            elapsedTime -= Time.deltaTime;
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
