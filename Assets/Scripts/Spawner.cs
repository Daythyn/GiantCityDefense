using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public float width = 10; //On either side of the center point
    public float toSpawn = 10;

    public float time = 0;
    public float timeCooldown = 10;

    public GameObject enemy;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Time to spawn  " + toSpawn + "  Enemies!!");
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 0){
            time -= Time.deltaTime;
        } else if(toSpawn > 0){
            spawn(enemy);
        }
    }

    void spawn(GameObject enemy){
        Vector3 point = this.transform.position + new Vector3(0,0,Random.Range(-width, width));
        GameObject baby = Instantiate(enemy, point, Quaternion.LookRotation(player.transform.position - point));
        baby.GetComponent<Enemy>().targetMain = player.gameObject;

        Debug.Log("Spawned baby at  " + point + "  !");
        time = timeCooldown;
        toSpawn--;
    }



}
