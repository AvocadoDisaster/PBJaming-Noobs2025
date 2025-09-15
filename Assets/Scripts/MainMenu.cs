using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : onload
{
    public void GoToScene(string sceneName) {
        SceneManager.LoadScene("Level");
        onload.Instantiate(this);
    }

    public void QuitApp() {
        Application.Quit();
        Debug.Log("Application has quit");
    }
    
}
