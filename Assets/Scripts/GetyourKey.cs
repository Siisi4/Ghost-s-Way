using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GetyourKey : MonoBehaviour
{
    public static int keyCount;
    public GameObject canvas;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "player"){
            keyCount += 1;
            Destroy(gameObject);
            canvas.SetActive(true);
        }

    }





}
