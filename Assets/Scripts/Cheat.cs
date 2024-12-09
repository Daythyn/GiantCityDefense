using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cheat : MonoBehaviour
{

    public Button button;
    public GameObject wood;
    public GameObject stone;
    public AudioSource clicky;

    private void Start() {
         button.onClick.AddListener(buttonClick);

        clicky = GetComponent<AudioSource>();
    }
    void buttonClick(){
        Instantiate(wood, transform.position, transform.rotation);
        Instantiate(wood, transform.position, transform.rotation);
        Instantiate(wood, transform.position, transform.rotation);
        Instantiate(stone, transform.position, transform.rotation);
        Instantiate(stone, transform.position, transform.rotation);
        Instantiate(stone, transform.position, transform.rotation);

        clicky.Play();
    }
}
