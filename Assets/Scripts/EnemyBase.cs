using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBase : MonoBehaviour
{

    public float healthMax;
    public float healthCurrent;
    public float speed;

    public float detectRange;

    public NavMeshAgent agent;
    public GameObject target = null;
    public GameObject targetMain;
    public GameObject targetSecondary;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void takeDamage(float damage){
        healthCurrent -= damage;
        if(healthCurrent <= 0){
            Debug.Log(this.name + "Died");
            Destroy(this.gameObject);
        }
    }

    public void test(){
        Debug.Log("Ahoy!");
    }
}
