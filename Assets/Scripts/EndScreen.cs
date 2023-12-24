using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public AudioSource audioSource;
    void OnTriggerExit(Collider other) {
        Debug.Log("END");
        if (other.tag == "Player") {
            UnityEngine.Cursor.lockState = UnityEngine.CursorLockMode.None;
            UnityEngine.Cursor.visible = true;
            SceneManager.LoadScene("EndScene");
            Debug.Log("END");
        }
    }
}
