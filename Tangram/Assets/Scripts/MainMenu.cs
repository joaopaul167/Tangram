using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
   public void ReloadLevel()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
    public void GoToMenu()
   {
       SceneManager.LoadScene("Menu");
   }
}
