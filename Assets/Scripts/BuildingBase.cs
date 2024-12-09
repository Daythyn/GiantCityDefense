using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingBase : MonoBehaviour
{


    public float healthMax;
    public float healthCurrent;

    public float reloadTime;
    public float reloadCurrent = 0;

    public int range;
    public SphereCollider detect;
    public List<GameObject> targets = new List<GameObject>();
    public GameObject targetCurrent = null;
    public AudioSource boomSound;
    public GameObject explosion;



    // Start is called before the first frame update
    void Start()
    {
        healthCurrent = healthMax;
        boomSound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnDestroy()
    {
        boomSound.Play();
        Instantiate(explosion, this.transform.position, this.transform.rotation);
    }
    public void takeDamage(float damage)
    {
        healthCurrent -= damage;
        if (healthCurrent <= 0)
        {
            Debug.Log(this.name + "Died");
            Destroy(this.gameObject);
        }
    }

    public void test()
    {
        Debug.Log("Ahoy!");
    }

}
