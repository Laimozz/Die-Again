using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FallDown : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    protected virtual void Awake()
    {
        rb =GetComponent<Rigidbody2D>();
    }

    public virtual void OnCollisionEnter2D(Collision2D collision)
    {
        CameraShake.instance.Play();
        Invoke("FallDownObj", 1f);
    }
    public virtual void FallDownObj()
    {
        rb.bodyType = RigidbodyType2D.Dynamic;
        rb.gravityScale = 1f;
    }
}
