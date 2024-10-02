using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportObj : MonoBehaviour
{
    [SerializeField] GameObject appearObj;
    private void Awake()
    {
        appearObj = GameObject.Find("Hazard4 (1)");
        appearObj.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Destroy(transform.parent.gameObject);
            appearObj.SetActive(true);

        }
    }
}
