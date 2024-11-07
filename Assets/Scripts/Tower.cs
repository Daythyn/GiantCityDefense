using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;


public class Tower : MonoBehaviour
{

    public GameObject projectile;
    public float projSpeed = 5;

    Vector3 spawn;

    private Boolean hasSpawn = false;


    // Start is called before the first frame update
    void Start()
    {
        spawn = new Vector3(this.transform.localPosition.x, this.transform.localScale.y + 1f, this.transform.localPosition.z);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (!hasSpawn)
        {
            hasSpawn = true;
            GameObject proj = Instantiate(projectile, spawn, transform.rotation);
            proj.GetComponent<Projectile>().target = other.gameObject;
            
        }

    }
}
