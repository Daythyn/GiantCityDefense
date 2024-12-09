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
<<<<<<< HEAD
    public AudioSource boom;
=======
    public AudioSource boomSound;
>>>>>>> 85137bfbf035f3b50e133e1a9f0d1bf4e94e16fb
    public GameObject explosion;



    // Start is called before the first frame update
    void Start()
    {
        healthCurrent = healthMax;
<<<<<<< HEAD
        boom.GetComponent<AudioSource>();
=======
        boomSound.GetComponent<AudioSource>();
>>>>>>> 85137bfbf035f3b50e133e1a9f0d1bf4e94e16fb
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void takeDamage(float damage)
    {
        healthCurrent -= damage;
        if (healthCurrent <= 0)
        {
            Debug.Log(this.name + "Died");
<<<<<<< HEAD
            boom.Play();
=======
            boomSound.Play();
>>>>>>> 85137bfbf035f3b50e133e1a9f0d1bf4e94e16fb
            Instantiate(explosion, this.transform.position, this.transform.rotation);
            Destroy(this.gameObject);
        }
    }

    public void test()
    {
        Debug.Log("Ahoy!");
    }

}
