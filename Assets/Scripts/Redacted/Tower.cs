using System;
using System.Collections;
using System.Collections.Generic;
using Palmmedia.ReportGenerator.Core.Parser.Analysis;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;


public class Tower : BuildingBase
{

    public GameObject projectile;
    public float projSpeed = 10;
    public float reloadTime = 1; //seconds, for some reason you need biggus numbers to make it work?
    public float reload = 0;

    Vector3 spawn;

    private Boolean hasShot = true;


    // Start is called before the first frame update
    void Start()
    {
        spawn = new Vector3(this.transform.localPosition.x, this.transform.localScale.y + 1f, this.transform.localPosition.z);
        test();

    }

    // Update is called once per frame
    void Update()
    {
        if(reload > 0){
            reload -= Time.deltaTime;
        } else if(hasShot == false){
            hasShot = true;
        }
    }

    void OnTriggerStay(Collider other)
    {

        if (hasShot == true)
        {
            if (other.CompareTag("Enemy"))
            {

                GameObject proj = Instantiate(projectile, spawn, Quaternion.LookRotation(other.transform.position - spawn));
                proj.GetComponent<Projectile>().speed = projSpeed;
                proj.GetComponent<Projectile>().target = other.gameObject;

                hasShot = false;
                reload = reloadTime;
            }
        }

    }
}
