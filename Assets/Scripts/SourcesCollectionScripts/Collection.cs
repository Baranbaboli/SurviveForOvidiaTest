using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collection : MonoBehaviour
{
    [HideInInspector]
    public float tpm;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameManager.staticOdunTop.SetActive(true);       
            tpm = GameManager.ControlTime;
            this.gameObject.GetComponent<MeshRenderer>().enabled=false;
            Destroy(this.gameObject, 3);
        }   
    }

    private void Update()
    {
        if (tpm + 1.5f < GameManager.ControlTime)
        {
            GameManager.staticOdunTop.SetActive(false);
            tpm = GameManager.ControlTime;
        }
    }
}
