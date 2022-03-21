using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AnimalMovement : MonoBehaviour
{
    public bool cowardAnimal = false;
    Vector3 randomDirection,tmp;


    public Transform player;


    [Tooltip("yapay zeka'n�n rastgele haraket etme zaman�")]
    public int moveTime = 3;
    private float timer = 0f;
    private bool randomDest = true;

    private void Awake()
    {       
        randomDirection = this.gameObject.transform.position + new Vector3(Random.Range(-5.0f, 5.0f), 0, Random.Range(-7.0f, 7.0f)); //7 birimkare alanda rastgele nokta
    }

    private void Start()
    {
        this.GetComponent<NavMeshAgent>().SetDestination(randomDirection);
        player = GameManager.playerStatic.transform;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= moveTime && randomDest == true)
        {
            timer = 0f;
            randomDirection = this.gameObject.transform.position + new Vector3(Random.Range(-7.0f, 7.0f),0, Random.Range(-7.0f, 7.0f));
            this.GetComponent<NavMeshAgent>().SetDestination(randomDirection);
        }
        else if (!randomDest && !cowardAnimal)
        {
            this.GetComponent<NavMeshAgent>().SetDestination(player.position);
        }
        else if(!randomDest && cowardAnimal)
        {
            tmp = transform.position - player.transform.position;
            GetComponent<NavMeshAgent>().SetDestination(transform.position + tmp);
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            randomDest = false; //hayvan insan taraf�ndan trigger'lanm��t�r. Alan i�erisinde insan� kovalar. (trigger collider 30br^2)
            this.GetComponent<NavMeshAgent>().speed *=2;    //alana girince sald�rgan daha h�zl�
        }
       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            randomDest = true;  //hayvan rastgele haraketine d�nme engeli kalkar
            this.GetComponent<NavMeshAgent>().speed /= 2;   //alandan ��k�nca normal harakete d�n�yor, h�z� da normal oluyor.
            this.GetComponent<NavMeshAgent>().SetDestination(randomDirection);
        }
    }
}
