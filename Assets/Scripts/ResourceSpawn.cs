using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ResourceSpawn : MonoBehaviour
{


    public GameObject resource;
    public Vector3 attachPos;
    public Boolean hasResource;

    public float cooldown;
    public float cooldownCurrent;

    XRSocketInteractor socket;


    // Start is called before the first frame update
    void Start()
    {
        hasResource = false;
        socket = this.GetComponent<XRSocketInteractor>();
    }

    // Update is called once per frame
    void Update()
    {

        if(socket.hasSelection){
            hasResource = true;
        } else{
            hasResource = false;
        }

        if(cooldownCurrent > 0 && hasResource == false){
            cooldownCurrent -= Time.deltaTime;
        } else if (!hasResource){
            GameObject proj = Instantiate(resource, transform.position, transform.rotation);
            cooldownCurrent = cooldown;
        }
    }

}
