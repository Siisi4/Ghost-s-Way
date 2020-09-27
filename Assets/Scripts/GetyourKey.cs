using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetyourKey : MonoBehaviour
{


    public GameObject key;

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
            key.SetActive(false);
        }
    } 
    




}
