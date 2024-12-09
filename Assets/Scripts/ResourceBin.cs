using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ResourceBin : MonoBehaviour
{
    public int wood = 0;
    public int stone = 0;

    public TMP_Text textStone;
    public TMP_Text textWood;
    public GameObject collectParticles;

    private void Update()
    {
        textStone.text = "Stone: " + stone;
        textWood.text = "Wood: " + wood;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rock")
        {
            Destroy(other.gameObject);
            stone += 1;

        }
        else if (other.tag == "Wood")
        {
            Destroy(other.gameObject);
            wood += 1;
        }
        Instantiate(collectParticles, this.transform.position, this.transform.rotation);
    }
}
