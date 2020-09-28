using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHolder : MonoBehaviour
{
    private static SoundHolder son;
    
    private void Awake()
    {
        if(son != null)
        {
            Destroy(gameObject);
        }
        else
        {
            son = this;
            DontDestroyOnLoad(transform.gameObject);
        }

    }
}
