using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagen : MonoBehaviour
{

    public GameObject hexagon;

    public float scale = 1;
    public int hexLayers = 0;
    public float offset = 0;
    Vector3 center = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        genHex();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void genHex()
    {
        float size = 1 * scale;
        float horiSpace = size * (float)Math.Sqrt(3) + offset;
        float vertSpace = size * 1.5f + offset;
        int midRowSize = (hexLayers * 2) + 1;
        Vector3 objScale = new Vector3(1 * scale, 1 * scale, 1 *scale);
        GameObject obj;

        //Main Row
        //Gen First
        Vector3 start = center - new Vector3(0, 0, horiSpace * hexLayers);
        for (int i = 0; i < midRowSize; i++)
        {
            obj = Instantiate(hexagon, start, Quaternion.identity);
            obj.transform.localScale = objScale;
            start += new Vector3(0, 0, horiSpace);
        }

        if (hexLayers > 0)
        {

            //Top half
            for (int i = 0; i < hexLayers; i++)
            {
                start = center - new Vector3(vertSpace * (i + 1), 0, horiSpace * ((midRowSize - (i + 2f)) / 2f)); //did i+1 incase I wanted to involve arrays later, so I can keep i=0 for now.
                for (int j = 0; j < (midRowSize - (i + 1)); j++)
                {
                    obj = Instantiate(hexagon, start, Quaternion.identity);
                    obj.transform.localScale = objScale;
                    start += new Vector3(0, 0, horiSpace);
                }
            }

            //Bottom half
            for (int i = 0; i < hexLayers; i++)
            {
                start = center - new Vector3(-vertSpace * (i + 1), 0, horiSpace * ((midRowSize - (i + 2f)) / 2f)); // Literally the same thing but vertSpace is negative
                for (int j = 0; j < (midRowSize - (i + 1)); j++)
                {
                    obj = Instantiate(hexagon, start, Quaternion.identity);
                    obj.transform.localScale = objScale;
                    start += new Vector3(0, 0, horiSpace);
                }
            }








        }
    }
}
