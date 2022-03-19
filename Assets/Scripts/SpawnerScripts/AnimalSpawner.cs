using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject animal;
    public Transform[] spawnPoints;

    void Start()
    {
        Instantiate(animal, transform.position, Quaternion.identity, transform.parent);
    }


    void Update()
    {
        
    }
}
