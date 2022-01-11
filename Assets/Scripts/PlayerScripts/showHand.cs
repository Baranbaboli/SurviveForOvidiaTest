using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHand : MonoBehaviour
{
    private bool hide = false;
    public GameObject handObj;

    private void Start()
    {
        handObj.transform.position = this.transform.position;
    }

    void Update()
    {
        handObj.transform.position = this.transform.position;


        if (Input.GetKeyDown(KeyCode.E) && !hide)
        {
            handObj.SetActive(false);
            hide = true;
        }
        else if(Input.GetKeyDown(KeyCode.E) && hide)
        {
            handObj.SetActive(true);
            hide = false;
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && !hide)
        {
            handObj.transform.Rotate(0.0f, 0.0f,  + 20, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && !hide)
        {
            handObj.transform.Rotate(0.0f, 0.0f,  - 20, Space.World);
        }

    }
}
