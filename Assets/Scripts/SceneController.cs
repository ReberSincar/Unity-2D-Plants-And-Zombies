using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("1.Menu");
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("4.GameOver");
    }

    public void LoadWin()
    {
        SceneManager.LoadScene("3.Win");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("2.Game");
    }

    public void LoadSceneByName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadSceneByIndex(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
