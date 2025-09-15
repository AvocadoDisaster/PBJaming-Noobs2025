using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : onload
{
    public AudioSource introSong;
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene("Level");
        onload.Instantiate(this);
        StopMusic();
    }

    public void QuitApp()
    {
        StopMusic();
        Application.Quit();
        Debug.Log("Application has quit");
    }
    void StopMusic()
    {
        introSong.Stop();
    }
    
}
