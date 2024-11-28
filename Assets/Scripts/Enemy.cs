using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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


        targetInit();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(target == null || target.IsDestroyed()){
            targetInit();
        }

        if(targetFindTimeCurrent > 0){
            targetFindTimeCurrent -= Time.deltaTime;
        } else {
            targetInit();
            targetFindTimeCurrent = targetFindTime;
        }



        agent.destination = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z); //Feels really expensive to run
        transform.LookAt(targetMain.transform.position);


        if(reloadCurrent > 0){
            reloadCurrent -= Time.deltaTime;
        } else if (Vector3.Distance(transform.position, new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z)) <= rangeAttack){
            
            //agent.updatePosition = false;

            target.GetComponent<BuildingBase>().takeDamage(damage);
            Debug.Log(this.gameObject + " Dealt " + damage + " Damage to " + target);
            reloadCurrent = reloadTime;
        }
        //} else if(agent.updatePosition == false){
            //agent.updatePosition = true;
        //}

    }

    

}
