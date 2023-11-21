using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDectection : MonoBehaviour
{
    public chase _chase;

    void OnTriggerStay(Collider other)
    {
        if(other.GetComponent<Collider>().gameObject.tag == "Player")
        {
            _chase.playerWalkedPast(false);
            Debug.Log("not");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Collider>().gameObject.tag == "Player")
        {
            _chase.playerWalkedPast(true);
            Debug.Log("pass");
            FindObjectOfType<AudioManager>().Play("chaseStart");
        }
    }
}
