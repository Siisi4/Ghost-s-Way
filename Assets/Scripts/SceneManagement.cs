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

}
