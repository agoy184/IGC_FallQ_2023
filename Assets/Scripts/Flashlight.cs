using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{

    public GameObject flashlight;
    

    private bool on;
    private bool off;

    // Start is called before the first frame update
    void Start()
    {
        off = true;
        flashlight.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (off && Input.GetKeyDown("f")){
            Debug.Log("works");
            flashlight.SetActive(true);
            off = false;
            on = true;
        }
        else if (on && Input.GetKeyDown("f")){
            Debug.Log("works2");
            flashlight.SetActive(false);
            off = true;
            on = false;
        }
    }
}
