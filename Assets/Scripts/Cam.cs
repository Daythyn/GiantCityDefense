using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.UIElements;

public class Cam : MonoBehaviour
{

    public int speed = 5;
    Vector3 move;
    Vector3 spin;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float Hinput = Input.GetAxis("Horizontal");
        float Vinput = Input.GetAxis("Vertical");
        float zoom = Input.GetAxis("Jump");
        float lr = Input.GetAxis("Mouse X");
        float ud = Input.GetAxis("Mouse Y");
        float tt = Input.GetAxis("Mouse ScrollWheel");

        move = new Vector3(0, 0, 0);
        spin = new Vector3(0, 0, 0);


        if (Hinput != 0)
        {
            move += new Vector3(Hinput, 0, 0);
        }
        if (Vinput != 0)
        {
            move += new Vector3(0, 0, Vinput);
        }
        if (zoom != 0)
        {
            move += new Vector3(0, zoom, 0);
        }
        if (lr != 0)
        {
            spin += new Vector3(0,lr,0);
        }
        if (lr != 0)
        {
            spin += new Vector3(ud,0,0);
        }
        if (tt != 0)
        {
            spin += new Vector3(0,0,tt);
        }

        transform.Translate(move * speed * Time.deltaTime) ;
        if(Input.GetMouseButton(1)){
            transform.Rotate(-spin * speed * 100 * Time.deltaTime) ;
        }
        
    }
}
