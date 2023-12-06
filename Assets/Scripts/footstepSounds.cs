using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class footstepSounds : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] stepSounds;
    public string[] soundTags;
    public Transform groundCheck;
    float castDistance = 1.5f;

    bool moving;
    // Update is called once per frame

    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            Debug.Log("moving");
            moving = true;
        }
        else
        {
            moving = false;
        }

        if (!moving)
        {
            return;
        }
        RaycastHit hit;
        if (Physics.Raycast(groundCheck.position, Vector3.down, out hit, castDistance))
        {
            Debug.Log(hit.collider.tag);
            for (int i = 0; i < stepSounds.Length; i++)
            {
                
                if(hit.collider.tag == soundTags[i])
                {
                    Debug.Log("working");
                    audioSource.clip = stepSounds[i];
                    if (!audioSource.isPlaying)
                    {
                        //audioSource.Play();
                    }
                }
            }

        }
        else
        {
            audioSource.Pause();
            Debug.Log("not wokring");
        }
    }
}
