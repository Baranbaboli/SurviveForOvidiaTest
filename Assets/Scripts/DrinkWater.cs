using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class DrinkWater : MonoBehaviour
{

    public Image ThirstImage;
    public Image HealthImage;
    private bool matara = false;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Drink" && matara)
        {
            Debug.Log("Su içiliyor...");
            ThirstImage.transform.localPosition = ThirstImage.transform.localPosition+(new Vector3(+1, 0, 0)/4);
        }
        else if (other.tag == "Bed" && Input.GetKeyDown(KeyCode.T))
        {
            SceneManager.LoadScene("LoadScene");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Animal")
        {
            HealthImage.transform.localPosition = HealthImage.transform.localPosition + (new Vector3(-10, 0, 0));
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
            transform.GetChild(0).GetChild(1).gameObject.SetActive(false);
            matara = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            transform.GetChild(0).GetChild(0).gameObject.SetActive(false);
            transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
            matara = false;
        }
            



        if (Input.GetKey(KeyCode.LeftShift))
        {
            ThirstImage.transform.localPosition = ThirstImage.transform.localPosition + (new Vector3(-1, 0, 0)/4);
            Debug.Log("Koþuluyor...");
        }
    }
}
