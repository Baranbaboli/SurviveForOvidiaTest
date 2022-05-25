using System.Collections;
using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class WolfAnimations : MonoBehaviour
{

    public GameObject dyingWolf;



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Axe" && GameManager.staticPlayerLevel == 10)
        {
            Instantiate(dyingWolf, transform.position, Quaternion.Euler(0, 90, 0));
            Destroy(this.gameObject);
        }
    }

}
