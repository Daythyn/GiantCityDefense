using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Status : MonoBehaviour
{
    public TMP_Text textHealth;
    public TMP_Text textKills;

    public PlayerBody player;

    public int kills;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textHealth.text = "Health: " + player.healthCurrent;
        textKills.text = "Kills: " + kills;
    }
}
