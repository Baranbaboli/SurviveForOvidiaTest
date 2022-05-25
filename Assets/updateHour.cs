using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateHour : MonoBehaviour
{

    public Text hour;
    private int x = 0;
    // Update is called once per frame
    void Update()
    {
        x = (int)GameManager.TimeOfDay; //saat
        hour.text = x.ToString();
    }
}
