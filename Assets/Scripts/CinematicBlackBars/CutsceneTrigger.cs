using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTrigger : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other){
        if(CinematicBarsController.Instance != null){
             CinematicBarsController.Instance.ShowBars();
             CameraChange.Key.setTrigger();
            }
    }
}
