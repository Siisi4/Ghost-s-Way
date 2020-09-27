using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torcher : MonoBehaviour
{

    public GameObject torche;
    public GameObject torchej;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            torche.SetActive(false);
            Debug.Log("torche triggered");
            torchej.SetActive(true);
        }
    }

}
