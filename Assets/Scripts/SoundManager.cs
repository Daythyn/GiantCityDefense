using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip track1;
    public AudioClip track2;
    private AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        music.clip = track1;
    }

    // Update is called once per frame
    void Update()
    {
        //music.Play();
        if(!music.isPlaying && music.clip == track1){
            music.clip = track2;
            music.Play();
        }

        if(!music.isPlaying && music.clip == track2){
            music.clip = track1;
            music.Play();
        }
    }
}
