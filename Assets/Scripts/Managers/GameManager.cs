using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    static public float ControlTime = 0f;

    [Header("Day&Night Time Settings")]
    public bool fastDay = false;
    static public float TimeOfDay = 7f; 
    [Tooltip("LightningManager'deki de�er ile ayn� olmal�.")]
    [SerializeField, Range(0, 24)] private float TimeOfDay_gm = 0; //lightningManager ile ayn� olmal�.


    void Start()
    {
        ControlTime = 0f;
        TimeOfDay = TimeOfDay_gm;
    }


    void Update()
    {
        ControlTime += Time.deltaTime; //Scene ba�lat�ld���ndan beri ge�en zaman.
        dayTime(); //spawner zaman kontrol� i�in g�ncellenen g�n zaman�.
    }


    void dayTime()
    {
        if (fastDay)
        {
            TimeOfDay += Time.deltaTime / 10;
            TimeOfDay %= 24;
        }
        else
        {
            TimeOfDay += Time.deltaTime / 100;
            TimeOfDay %= 24;
        }
    }
}
