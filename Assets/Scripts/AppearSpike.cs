using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearSpike : MonoBehaviour
{
    [SerializeField] float timeToAppear = 0.7f;
    void Awake()
    {
        transform.GetChild(0).gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Invoke("Appear" , timeToAppear);
        }
    }
    public void Appear()
    {
        transform.GetChild(0).gameObject.SetActive(true);
    }
}
