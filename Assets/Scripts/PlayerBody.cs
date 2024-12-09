using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBody : MonoBehaviour
{

    public int healthMax;
    public int healthCurrent;

    public Boolean canDie;


    // Start is called before the first frame update
    void Start()
    {
        healthCurrent = healthMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeDamage(int damage)
    {
        healthCurrent -= damage;
        if (healthCurrent <= 0 && canDie)
        {
            SceneManager.LoadScene("Credits");
            Debug.Log(this.name + "Died");
            Destroy(this.gameObject);
        }
    }
}
