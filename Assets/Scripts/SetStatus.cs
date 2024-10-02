using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetStatus : MonoBehaviour
{
    [SerializeField] BoxCollider2D boxCollider;
     void Awake()
    {
       boxCollider = transform.parent.GetComponent<BoxCollider2D>();
        boxCollider.isTrigger = true;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
     if(other.tag == "Player")
        {
            boxCollider.isTrigger = false;
        }   
    }
}
