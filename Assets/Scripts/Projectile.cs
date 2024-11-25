using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public GameObject target;
    public float speed;
    public float damage;

    public Vector3 targetLastPos;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (!target.IsDestroyed())
        {
            targetLastPos = target.transform.position;
        }
        else if (Vector3.Distance(this.transform.position, targetLastPos) < 0.1)
        {
            Destroy(this.gameObject);
        }

        transform.position = Vector3.MoveTowards(transform.position, targetLastPos, speed * Time.deltaTime);
        transform.rotation = Quaternion.LookRotation(targetLastPos - this.transform.position);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Target HIT!!!1!");
            other.GetComponent<EnemyBase>().takeDamage(damage);
            Destroy(this.gameObject);
        }
    }

}
