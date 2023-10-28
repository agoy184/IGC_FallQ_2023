using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    public float shakeDuration = 0.5f;
    public float shakeMagnitude = 0.7f;
    private Vector3 originalPosition;
    private float remainingShakeDuration = 0f;

    public void TriggerShake()
    {
        remainingShakeDuration = shakeDuration;
    }

    void Update()
    {
        if (remainingShakeDuration > 0)
        {
            transform.localPosition = originalPosition + Random.insideUnitSphere * shakeMagnitude;
            remainingShakeDuration -= Time.deltaTime;
        }
        else
        {
            remainingShakeDuration = 0f;
            transform.localPosition = originalPosition;
        }
    }

    void Awake()
    {
        originalPosition = transform.localPosition;
    }
}
