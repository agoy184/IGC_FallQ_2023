using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MusicOnExit : MonoBehaviour
{
    public AudioSource audioSource;
    void OnTriggerExit(Collider other) {
        Debug.Log("3");
        if (other.tag == "Player") {
            audioSource.volume = 0.2f;
            Debug.Log("4");
        }
    }
}
