using UnityEngine;
using System.Collections;
using System;
public class SlideBackFore : MonoBehaviour
{
    public GameObject Pos2;
    public GameObject Pos3;
    [SerializeField] float moveSpeed = 0.02f;

     void Update()
    {
        if(PosForMoveAndBack.instance.isMove)
        MoveToward();
    }
    public void MoveToward()
    {
        if (transform.position == Pos3.transform.position)
        {
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, Pos2.transform.position, moveSpeed);

        if(transform.position == Pos2.transform.position)
        {
            Pos2.transform.position = Pos3.transform.position;
        }

    }
}