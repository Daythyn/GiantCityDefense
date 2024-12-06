using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    // public Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        SceneManager.LoadScene("Alternate");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
