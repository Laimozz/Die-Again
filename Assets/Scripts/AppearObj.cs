using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearObj : MonoBehaviour
{
    [SerializeField] SpriteRenderer spriteRenderer;

    void Awake()
    {
         spriteRenderer = GetComponent<SpriteRenderer>();
         spriteRenderer.enabled = false;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
            spriteRenderer.enabled = true;
    }
}
