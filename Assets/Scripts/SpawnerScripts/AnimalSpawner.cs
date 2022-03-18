using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject animal;


    void Start()
    {
        Instantiate(animal, transform.position, Quaternion.identity, transform.parent);
    }


    void Update()
    {
        
    }
}
