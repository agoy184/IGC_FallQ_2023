using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seeingMonster : MonoBehaviour
{
    public GameObject monsterCube;
    bool canInvoke;
    public chase _chase;
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }



    // Update is called once per frame
    void FixedUpdate()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(.5f, .5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if(hit.collider.tag == monsterCube.tag)
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                _chase.spottedMonster();
                //Debug.Log("Looking");
            }
            
        }
    }
}
