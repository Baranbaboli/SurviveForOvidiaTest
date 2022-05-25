using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameObject playerStatic;
    static public float ControlTime = 0f;
    static public float staticPlayerLevel;


    [Header("Player Settings")]
    public GameObject player;
    public float PlayerLevel = 1;
    [Range(0, 100)] public float PlayerHealth = 100;
    [Range(0, 100)] public float PlayerThirst = 100;
    static public float Phealth;
    static public float Pthirst;

    public GameObject odunTop;
    static public GameObject staticOdunTop;

    [Header("Day&Night Time Settings")]
    public bool fastDay = false;
    static public float TimeOfDay = 7f; 
    [Tooltip("LightningManager'deki de�er ile ayn� olmal�.")]
    [SerializeField, Range(0, 24)] private float TimeOfDay_gm = 0; //lightningManager ile ayn� olmal�.

    private void Awake()
    {
        staticPlayerLevel = PlayerLevel;
    }

    void Start()
    {
        ControlTime = 0f;
        TimeOfDay = TimeOfDay_gm;
        playerStatic = player;
        staticOdunTop = odunTop;

        Phealth = PlayerHealth;
        Pthirst = PlayerThirst;
    }


    void Update()
    {
        ControlTime += Time.deltaTime; //Scene ba�lat�ld���ndan beri ge�en zaman.
        dayTime(); //spawner zaman kontrol� i�in g�ncellenen g�n zaman�.

        Phealth = PlayerHealth;
        Pthirst = PlayerThirst;
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
