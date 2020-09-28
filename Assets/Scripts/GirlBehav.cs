using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GirlBehav : MonoBehaviour
{
    public GameObject subtitle;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            subtitle.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            subtitle.SetActive(true);

        }

    }
}
