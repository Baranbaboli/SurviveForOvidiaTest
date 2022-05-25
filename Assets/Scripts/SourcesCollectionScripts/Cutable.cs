using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cutable : MonoBehaviour
{
    public GameObject log;
    private int counter = 0;
    private int breakTimer = 1;

    [HideInInspector]
    public float instantiateTime = 5f;
    [HideInInspector]
    public float set = 0f;
    [HideInInspector]
    public bool logSpawn = false;

    private void Start()
    {
        instantiateTime = 5f;
        set = 0f;
        logSpawn = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Axe")
        {
            Debug.Log("Axe triggered");
            Debug.Log(GameManager.staticPlayerLevel);
            counter++;
        }
        
    }


    private void OnTriggerExit(Collider other)
    {
        //Debug.Log("Hitted " + counter + " times");               
        breakTimer = Random.Range(1, 100);                        //rastgele olan sayı her ağaç kesimi için farklı ihtimallerde kırılmasına olanak tanır.
        
        //Debug.Log("breakTimer: " + breakTimer);

        if (counter > 6 && breakTimer > 60)                       //1-100 arasında breakTimer'a sayı atanıyor. 60 > olması düz mantık %40 ihtimal başarılı.
        {
            //Debug.Log("CUTTED");
            transform.GetChild(1).gameObject.SetActive(false);  //bu aktife etme ve deaktife etmek için rigidbody'li objeyi yaratmak daha efektif!
            transform.GetChild(0).gameObject.SetActive(true);
            Destroy(this.gameObject, 5f);
            logSpawn = true;
            set = GameManager.ControlTime;
        }
        else if (GameManager.staticPlayerLevel == 10)
        {
            transform.GetChild(1).gameObject.SetActive(false);  //bu aktife etme ve deaktife etmek için rigidbody'li objeyi yaratmak daha efektif!
            transform.GetChild(0).gameObject.SetActive(true);
            Destroy(this.gameObject, 5f);
            logSpawn = true;
            set = GameManager.ControlTime;
        }
    }

    private void Update()
    {
        if (logSpawn && GameManager.ControlTime > set + instantiateTime)
        {
            for (int i = 0; i < 2; i++)
            {
                Instantiate(log, transform.position, Quaternion.Euler(0,90,0), transform.parent);            
            }
            logSpawn = false;
            set = GameManager.ControlTime;
        }
    }



}
