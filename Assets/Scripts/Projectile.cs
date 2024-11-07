using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public GameObject target;
    public float speed = 1;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        //transform.rotation = Quaternion.LookRotation((Vector3.RotateTowards(transform.position, target.transform.position, 1 * Time.deltaTime, 1 * Time.deltaTime)));
    }
}
