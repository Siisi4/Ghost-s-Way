using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Application.Quit");
    }

    public void RetourMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void MenuCredit()
    {
        SceneManager.LoadScene("Credit");
    }
}
