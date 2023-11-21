using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartCutscene : MonoBehaviour
{
    public static StartCutscene Instance {get; private set;}
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

    void Start(){
        
        
    }

    public void RemoveBars(){
        cinematicBarControllerGo.SetActive(true);
    }



    
}
