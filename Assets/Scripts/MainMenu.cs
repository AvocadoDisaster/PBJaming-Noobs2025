using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource introSong;

    public void GoToScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
        StopMusic();
    }

    public void QuitApp() {
        StopMusic();
        Application.Quit();
        Debug.Log("Application has quit");

    }
    void StopMusic()
    {
        introSong.Stop();
    }
}
