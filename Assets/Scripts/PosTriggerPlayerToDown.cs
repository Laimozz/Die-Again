using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosTriggerPlayerToDown : TriggerPlayer
{
    public static PosTriggerPlayerToDown instance;
    public bool isDown;
    private void Awake()
    {
        instance = this;
    }
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        if(other.tag == "Player")
        {
            isDown = true;
        }
    }
}
