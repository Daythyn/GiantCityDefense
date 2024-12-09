using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class ResourceButtonSpawn : MonoBehaviour
{


    public GameObject ResourceToSpawn;
    public GameObject ResourceManager;
    XRSocketInteractor socket;
    public Button button;
    Boolean hasResource;

    public int requiredWood;
    public int requiredStone;

    public TMP_Text textStone;
    public TMP_Text textWood;
    public TMP_Text textName;
    public String ResourceName;

    public GameObject socketSource;

    public AudioSource click;



    // Start is called before the first frame update
    void Start()
    {
        socket = socketSource.GetComponent<XRSocketInteractor>();

        button.onClick.AddListener(clicked);

        click = GetComponent<AudioSource>();
    }

    void Update(){
        if(socket.hasSelection){
            hasResource = true;
        } else{
            hasResource = false;
        }

        textStone.text = "Stone: " + requiredStone;
        textWood.text = "Wood: " + requiredWood;
        textName.text = ResourceName;
    }

    void clicked()
    {
        //Debug.Log(ResourceManager.GetComponent<ResourceBin>().wood + " " + ResourceManager.GetComponent<ResourceBin>().stone + " " + hasResource);
        if (ResourceManager.GetComponent<ResourceBin>().wood >= requiredWood && ResourceManager.GetComponent<ResourceBin>().stone >= requiredStone && hasResource == false)
        {
            GameObject proj = Instantiate(ResourceToSpawn, transform.position, transform.rotation);
            ResourceManager.GetComponent<ResourceBin>().wood -= requiredWood;
            ResourceManager.GetComponent<ResourceBin>().stone -= requiredStone;
            click.Play();
        }
    }





}
