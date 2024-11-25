using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : EnemyBase
{


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;

        target = targetMain;

        healthCurrent = healthMax;
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null){
            target = targetMain;
        }
        agent.destination = target.transform.position;
    }
}
