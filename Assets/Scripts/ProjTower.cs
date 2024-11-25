using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class ProjTower : BuildingBase
{

    public float HealthMax;
    private float HealthCurrent;

    public float reloadTime;
    public float reloadCurrent = 0;

    public GameObject turret;
    public float turretTurnSpeed;

    public GameObject projectile;
    public float projectileSpeed;
    public float projectileDamage;

    public int range;
    private SphereCollider detect;
    private List<GameObject> targets = new List<GameObject>();
    public GameObject targetCurrent = null;

    private Boolean canShoot;






    // Start is called before the first frame update
    void Start()
    {
        test();

        detect = this.GetComponent<SphereCollider>();
        detect.radius = range;

        HealthCurrent = HealthMax;
        canShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(targetCurrent == null && targets.Count > 0){
            targetCurrent = targets[0];

            if(targetCurrent.IsDestroyed()){
                targetCurrent = null;
                targets.RemoveAt(0);
            }

            if(!targets.Contains(targetCurrent)){
                targetCurrent = null;
            }
        }

        if(!targetCurrent.IsDestroyed() && targetCurrent != null){
            turret.transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(targetCurrent.transform.position, turret.transform.position, turretTurnSpeed * Time.deltaTime, turretTurnSpeed * Time.deltaTime));
        }

        if(reloadCurrent > 0){
            reloadCurrent -= Time.deltaTime;
        } else if (canShoot && targetCurrent != null){
            canShoot = false;
            shoot();
        }
    }

    void aim(){
        
    }
    void shoot(){
        Debug.Log("Preparing to Fire");
        if(!targetCurrent.IsDestroyed()){

            GameObject proj = Instantiate(projectile, turret.transform.position, Quaternion.LookRotation(targetCurrent.transform.position - turret.transform.position));
                proj.GetComponent<Projectile>().speed = projectileSpeed;
                proj.GetComponent<Projectile>().target = targetCurrent;

                reloadCurrent = reloadTime;
                Debug.Log("FIRE");
        }
        canShoot = true;
    }



    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy"){
            targets.Add(other.gameObject);
            Debug.Log("Found: " + other.gameObject.name);
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (targets.Contains(other.gameObject))
        {
            targets.Remove(other.gameObject);
        }
        Debug.Log("Lost: " + other.gameObject.name);
    }
}
