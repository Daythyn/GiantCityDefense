using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBase : MonoBehaviour
{

    public float healthMax;
    public float healthCurrent;
    public float speed;
    public float damage;

    public float rangeDetect;
    public float rangeAttack;

    public float reloadTime;
    public float reloadCurrent;



    public NavMeshAgent agent;
    public float targetFindTime = 10; //Seconds between attempts to update/find a target
    public float targetFindTimeCurrent;
    public GameObject target = null;
    public GameObject targetMain;
    public GameObject targetSecondary;
    public GameObject deathParticles;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void takeDamage(float damage){
        healthCurrent -= damage;
        if(healthCurrent <= 0){
            Instantiate(deathParticles, this.transform.position, this.transform.rotation);
            Debug.Log(this.name + "Died");
            Destroy(this.gameObject);
        }
    }

    public void targetInit(){

            RaycastHit hit;
            // Does the ray intersect any objects excluding the player layer
            if (Physics.Raycast(transform.position, targetMain.transform.position - transform.position, out hit, 300, LayerMask.GetMask("Building", "Player"))){

                Debug.DrawRay(transform.position, targetMain.transform.position - transform.position * hit.distance, Color.yellow); 
                Debug.Log("Did Hit" + hit.rigidbody.gameObject); 

                target = hit.rigidbody.gameObject;
            }
    }




    public void test(){
        Debug.Log("Ahoy!");
    }
}
