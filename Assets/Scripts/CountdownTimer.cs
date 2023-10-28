using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
    public CameraShake cameraShake;

    public float totalTime = 10f;
    private float currentTime;

    public TextMeshProUGUI displayText;

    private bool timerAcitve = true;

    void Start()
    {
        currentTime = totalTime;
    }

    void Update()
    {
        if(timerAcitve)
        {
            currentTime -= Time.deltaTime;

            int minutes = Mathf.FloorToInt(currentTime / 60);
            int seconds = Mathf.FloorToInt(currentTime % 60);

            displayText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

            if(currentTime <=0)
            {
                timerAcitve = false;
                displayText.text = "Time to die";
                cameraShake.TriggerShake();
            }

        }
    }
}
