using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] float shakeDuration = 0.5f;
    [SerializeField] float shakeMagnitude = 0.25f;
    [SerializeField] Vector3 initialPosition;

    public static CameraShake instance;
    void Start()
    {
        instance = this;
        initialPosition = transform.position;
    }
    public void Play()
    {
        StartCoroutine(Shake());
    }

    IEnumerator Shake()
    {
        float elapsedTime = 0f;
        if(elapsedTime < shakeDuration)
        {
            transform.position = initialPosition +(Vector3)Random.insideUnitCircle * shakeMagnitude;
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        transform.position = initialPosition;
        
    }
}
