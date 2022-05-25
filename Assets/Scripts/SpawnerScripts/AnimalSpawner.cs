using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject[] animal;
    public Transform[] spawnPoints;

    public int spawnPerHour = 2;

    private int randomHour = 9;
    private int animalType = 0;
    void Start()
    {

        randomHour = Random.Range(17,20);
        spawnAnimal();
    }


    void Update()
    {
        Debug.Log("Hayvan akþam spawn zamaný randomHour: " + randomHour);
        if(GameManager.TimeOfDay > randomHour) // baþlangýç ve 3 farklý saat zamaný.
        {
            spawnAnimal();
            randomHour += spawnPerHour;
        }
    }

    void spawnAnimal()
    {
        for (int i = 0; i < 5; i++)
        {
            animalType = Random.Range(0, 6);
            Instantiate(animal[animalType], spawnPoints[i].position, Quaternion.identity, transform.parent);
            Instantiate(animal[animalType], spawnPoints[i].position, Quaternion.identity, transform.parent);
            if (Random.Range(0, 100) > 50)
            {
                Instantiate(animal[animalType], spawnPoints[i].position, Quaternion.identity, transform.parent);
            }
        }
    }

}
