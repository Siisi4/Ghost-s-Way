using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class GhostBehav : MonoBehaviour
{


    public GameObject subtitle;
    public Transform BotDirection;
    public GameObject ghost;

    void Start()
    {
        
    }


    void Update()
    {
        
        // joueur appuie sur E
        if (Input.GetKeyDown(KeyCode.E))
        {
             // les sous-titres disparaissent

            subtitle.SetActive(false);

            // bot navmesh agent s'active

            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = BotDirection.position;


        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            subtitle.SetActive(true);
            
        }

        if (other.CompareTag("destination"))
        {
            Destroy(ghost);
        }

    }

}
