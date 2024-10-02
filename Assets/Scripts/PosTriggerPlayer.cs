using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosTriggerPlayer : TriggerPlayer
{
    protected override void OnTriggerEnter2D(Collider2D other)
    {
        base.OnTriggerEnter2D(other);
        if (other.tag == "Player")
        {
            foreach (Transform child in transform)
            {
                CameraShake.instance.Play();
                child.GetComponent<FallHazard5>().Fall();
            }
            Invoke("SetIsMove", 3f);
        }
    }
    protected void SetIsMove()
    {
        PosForMoveAndBack.instance.isMove = true;
    }
}
