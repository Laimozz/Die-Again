using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoin : TriggerPlayer
{
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Destroy(transform.gameObject);
        }
    }
}
