using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallHazard5 : FallDown
{
    [SerializeField] float timeToFall = 0f;
    protected override void Awake()
    {
        base.Awake();
    }

    public void Fall() 
    {
        Invoke("FallDownObj", timeToFall);
    }
    public override void FallDownObj()
    {
        base.FallDownObj();
    }
    public override void OnCollisionEnter2D(Collision2D collision)
    {
    }
}
