using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : onload
{
<<<<<<< HEAD
    public void GoToScene(string sceneName) {
        SceneManager.LoadScene("Level");
=======
    public AudioSource introSong;
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene("Level");
        onload.Instantiate(this);
        StopMusic();
>>>>>>> 5a45df54f012873960deadba2bb72ceb19677a92
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
