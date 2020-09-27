using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class Cdoorbehav : MonoBehaviour
{
    public GameObject canvasbait;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            canvasbait.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            SceneManager.LoadScene("Game");
            Debug.Log("R pressed");

        }
    }
}
