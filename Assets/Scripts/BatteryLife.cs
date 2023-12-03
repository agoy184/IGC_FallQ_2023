using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryLife : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light;
    private float battery = 5;
    public float speed;
    
    
    void Start()
    {
        //light = GetComponent<Light>();
        light.intensity = battery;
    }

    // Update is called once per frame
    void Update()
    {
        battery -= Time.deltaTime * speed;
        light.intensity = battery;
    }
}
