using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Transform target;
    private bool inTrigger = false;
    public static CameraChange Key {get; private set;}
    // Start is called before the first frame update
    void Start()
    {
        inTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(inTrigger){
        StartCoroutine(CameraChanger());
        Debug.Log("works quite well");
        transform.LookAt(target);
        transform.Translate(Vector3.right * Time.deltaTime);
        }
        
    }

    private IEnumerator CameraChanger(){
        
        yield return new WaitForSeconds(2f);
        inTrigger = false;
    }

    public void setTrigger(){
        inTrigger = true;
    }

    
}
