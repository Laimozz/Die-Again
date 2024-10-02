using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPos : MonoBehaviour
{
    [SerializeField] GameObject PosDes;
    [SerializeField] float speed = 2f;
    public static MoveToPos insance;
    void Awake()
    {
        insance = this;    
    }
    void Update()
    {
        if (PosForMoveAndBack.instance.isMove)
        MoveToward();
    }
    public void MoveToward()
    {
        if (transform.position == PosDes.transform.position) return;

        transform.position = Vector3.MoveTowards(transform.position, PosDes.transform.position, speed);
    }
}
