using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float width = 10; //On either side of the center point

    public float time = 0;
    public float timeCooldown;
    public GameObject player;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timeCooldown > 0)
        {
            time -= Time.deltaTime;
        }
    }

    public void spawn(GameObject enemy, int count)
    {


        while (count > 0)
        {
            if (time >= 0)
            {
                Vector3 point = this.transform.position + new Vector3(0, 0, Random.Range(-width, width));
                GameObject baby = Instantiate(enemy, point, Quaternion.LookRotation(player.transform.position - point));
                baby.GetComponent<Enemy>().targetMain = player.gameObject;

                time = timeCooldown;
                count--;
            }

        }
    }



}
