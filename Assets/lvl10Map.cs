using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvl10Map : MonoBehaviour
{

    void Start()
    {
        if (GameManager.staticPlayerLevel == 10)
        {
            this.gameObject.SetActive(false);
        }
        else
            this.gameObject.SetActive(true);
    }

}
