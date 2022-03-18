using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimalMovement : MonoBehaviour
{
    public Transform player;

    private void Awake()
    {

    }
    void Start()
    {
        this.GetComponent<NavMeshAgent>().SetDestination(player.position);

    }


    void Update()
    {
        this.GetComponent<NavMeshAgent>().SetDestination(player.position);
    }
}
