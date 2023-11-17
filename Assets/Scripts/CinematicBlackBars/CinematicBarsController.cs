using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicBarsController : MonoBehaviour
{

    public static CinematicBarsController Instance {get; private set;}
    [SerializeField] private GameObject cinematicBarControllerGo;
    [SerializeField] private Animator cinematicBarsAnimator;

    private void Awake(){
        if(Instance == null){
            Instance = this;
        }
        else if(Instance != null){
            Destroy(gameObject);
        }
        cinematicBarControllerGo.SetActive(false);
    }

    public void ShowBars(){
        cinematicBarControllerGo.SetActive(true);
    }

    public void HideBars(){
        if(cinematicBarControllerGo.activeSelf){
            StartCoroutine(HideBarsAndDisableGO());
        }
    }

    private IEnumerator HideBarsAndDisableGO(){

        cinematicBarsAnimator.SetTrigger("HideBars");
        yield return new WaitForSeconds(0.5f);
        cinematicBarControllerGo.SetActive(false);
    }

    
}
