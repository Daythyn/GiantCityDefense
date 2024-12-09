using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceSpawn : MonoBehaviour
{


    public GameObject resource;
    public Vector3 attachPos;
    Boolean hasResource;

    public float cooldown;
    public float cooldownCurrent;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cooldown > 0){
            reloadCurrent -= Time.deltaTime;
        } else if (canShoot && targetCurrent != null){
            canShoot = false;
            shoot();
        }
    }
}
