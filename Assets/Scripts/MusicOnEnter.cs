using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MusicOnEnter : MonoBehaviour
{
    public AudioSource audioSource;
    void OnTriggerExit(Collider other) {
        Debug.Log("1");
        if (other.tag == "Player" && !audioSource.isPlaying) {
            audioSource.Play();
            Debug.Log("2");
        }
    }
}
