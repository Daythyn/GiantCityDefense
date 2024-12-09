using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticles : MonoBehaviour
{

    private int counter = 300;
    //private AudioSource boomSound;

    // Start is called before the first frame update
    void Start()
    {
        //boomSound = GetComponent<AudioSource>();
        //boomSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if(counter<0){
            Destroy(gameObject);
        }
        counter--;
    }
}
