using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] spawners;
    public int wave = 1;

    public float cooldown;
    public float cooldownCurrent;

    public GameObject gobbo;
    public GameObject ogre;

    public TMP_Text textWave;
    public TMP_Text textTime;
    public Button button;
    public AudioSource click;


    // Start is called before the first frame update
    void Start()
    {
button.onClick.AddListener(skip);

        click = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldownCurrent > 0)
        {
            cooldownCurrent -= Time.deltaTime;
        }
        else
        {
            cooldownCurrent = cooldown;
            spawnWave();
        }


        textWave.text = "Wave: " + wave;
        textTime.text = cooldownCurrent.ToString();


    }

    void skip(){
        cooldownCurrent = 0;
        click.Play();
    }

    void spawnWave()
    {
        int rand = Random.Range(0, 100 + wave);
        switch (wave)
        {
            case 1:
                spawners[rand % spawners.Length].GetComponent<Spawner>().spawn(gobbo, 100);
                break;
            case 2:
                spawners[rand % spawners.Length].GetComponent<Spawner>().spawn(gobbo, 10);
                break;
            case 3:
                spawners[0 % spawners.Length].GetComponent<Spawner>().spawn(gobbo, 10);
                spawners[1 % spawners.Length].GetComponent<Spawner>().spawn(gobbo, 10);
                break;
            case 4:
                spawners[rand % spawners.Length].GetComponent<Spawner>().spawn(gobbo, 20);
                spawners[rand % spawners.Length].GetComponent<Spawner>().spawn(ogre, 1);
                break;
            case 5:
                spawners[rand % spawners.Length].GetComponent<Spawner>().spawn(gobbo, 20);
                spawners[rand % spawners.Length].GetComponent<Spawner>().spawn(gobbo, 20);
                spawners[rand % spawners.Length].GetComponent<Spawner>().spawn(ogre, 1);
                spawners[rand % spawners.Length].GetComponent<Spawner>().spawn(ogre, 1);
                spawners[rand % spawners.Length].GetComponent<Spawner>().spawn(ogre, 1);
                break;
            case 6:
                spawners[0 % spawners.Length].GetComponent<Spawner>().spawn(ogre, 5);
                spawners[1 % spawners.Length].GetComponent<Spawner>().spawn(ogre, 5);
                break;
            case 7:
                spawners[rand % spawners.Length].GetComponent<Spawner>().spawn(gobbo, 50);
                break;
            case 8:
                spawners[0 % spawners.Length].GetComponent<Spawner>().spawn(gobbo, 30);
                spawners[1 % spawners.Length].GetComponent<Spawner>().spawn(ogre, 7);
                spawners[0 % spawners.Length].GetComponent<Spawner>().spawn(gobbo, 70);
                spawners[1 % spawners.Length].GetComponent<Spawner>().spawn(ogre, 3);
                break;
        }
        wave += 1;
    }
}