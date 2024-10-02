using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosForMoveAndBack : MonoBehaviour
{
    public bool isMove;
    public static PosForMoveAndBack instance;
    private void Awake()
    {
        instance = this;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            isMove = true;
        }
    }
}
