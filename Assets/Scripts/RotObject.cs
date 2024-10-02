using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotObject : MonoBehaviour
{
    [SerializeField] GameObject rotDes;
    [SerializeField] GameObject PosDes;
    [SerializeField] float speed = 1f;
    void Update()
    {
        if (PosTriggerPlayerToDown.instance.isDown)
        {
            RotateObj();
            MoveToward();
        }
        
    }
    public void RotateObj()
    {
        float speed = 10f * (1f - Mathf.Exp(-Time.deltaTime));
        Quaternion currentRot = transform.rotation;
        Quaternion targetRot = rotDes.transform.rotation;

        transform.rotation = Quaternion.Slerp(currentRot, targetRot, speed);
    }
    public void MoveToward()
    {
        if (transform.position == PosDes.transform.position) return;

        transform.position = Vector3.MoveTowards(transform.position, PosDes.transform.position, speed);
    }

}
