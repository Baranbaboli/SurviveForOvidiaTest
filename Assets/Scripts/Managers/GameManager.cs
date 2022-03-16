using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{


    static public float ControlTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        ControlTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        ControlTime += Time.deltaTime;
    }
}
