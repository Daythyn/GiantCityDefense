using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyWonder : MonoBehaviour
{

public NavMeshAgent agent;
public Vector3 dest;
public float closeness = 1;
public float roamability= 6;
public GameObject oof;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        dest = transform.position + new Vector3(5,0,5);
        agent.destination = dest;
    }

    // Update is called once per frame
    void Update()
    {

        

        if(Vector3.Distance(transform.position, dest) < closeness){
            dest = transform.position + new Vector3(Random.Range(-roamability,roamability),0,Random.Range(-roamability,roamability));
            agent.destination = dest;
        }
    }
}
