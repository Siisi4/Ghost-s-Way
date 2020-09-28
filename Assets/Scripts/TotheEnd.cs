using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TotheEnd : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "player" && GetyourKey.keyCount > 0)
        {
            GetyourKey.keyCount--;
            SceneManager.LoadScene("End");
        }
    }
}
