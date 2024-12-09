
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{

    public Spawner spawn1;
    public Spawner spawn2;
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

        Debug.Log(spawn1 + " " + spawn2);
        button.onClick.AddListener(skip);

        click = GetComponent<AudioSource>();
        Debug.Log("Bonk");
    }

    // Update is called once per frame
    void Update()
    {
        if (cooldownCurrent >= 0)
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

    void skip()
    {
        cooldownCurrent = 1;
        click.Play();
    }

    void spawnWave()
    {
        switch (wave)
        {
            case 1:
                spawn1.spawn(gobbo, 1);
                break;
            case 2:
                spawn2.spawn(gobbo, 10);
                break;
            case 3:
                spawn1.spawn(gobbo, 10);
                spawn2.spawn(gobbo, 10);
                break;
            case 4:
                spawn2.spawn(gobbo, 20);
                spawn2.spawn(ogre, 1);
                break;
            case 5:
                spawn1.spawn(gobbo, 20);
                spawn2.spawn(gobbo, 20);
                spawn1.spawn(ogre, 1);
                spawn2.spawn(ogre, 1);
                spawn2.spawn(ogre, 1);
                break;
            case 6:
                spawn1.spawn(ogre, 5);
                spawn2.spawn(ogre, 5);
                break;
            case 7:
                spawn1.spawn(gobbo, 50);
                break;
            case 8:
                spawn1.spawn(gobbo, 30);
                spawn1.spawn(ogre, 7);
                spawn2.spawn(gobbo, 70);
                spawn2.spawn(ogre, 3);
                break;
            case 9:
            SceneManager.LoadScene("Credits");
            break;
        }
        wave += 1;
    }
}