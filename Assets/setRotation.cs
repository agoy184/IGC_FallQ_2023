using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setRotation : MonoBehaviour
{
    public GameObject cubeMonster;
    

    // Update is called once per frame
    void Update()
    {
        Quaternion target = Quaternion.Euler(0,cubeMonster.transform.rotation.y, cubeMonster.transform.rotation.z);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime*20);
    }
}
