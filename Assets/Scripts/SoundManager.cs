using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioClip track1;
    public AudioClip track2;
    public AudioClip track3;
    public AudioClip track4;
    public AudioClip track5;
    public AudioClip track6;
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

        else if(!music.isPlaying && music.clip == track2){
            music.clip = track3;
            music.Play();
        }
        else if(!music.isPlaying && music.clip == track3){
            music.clip = track4;
            music.Play();
        }
        else if(!music.isPlaying && music.clip == track4){
            music.clip = track5;
            music.Play();
        }
        else if(!music.isPlaying && music.clip == track5){
            music.clip = track6;
            music.Play();
        }
        else if(!music.isPlaying && music.clip == track6){
            music.clip = track1;
            music.Play();
        }
        
    }
}
