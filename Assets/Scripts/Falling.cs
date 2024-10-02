using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    [SerializeField] float gravity;
    [SerializeField] Rigidbody2D rb;

    protected virtual void Awake()
    {
        this.gravity = 3f;
        rb = GetComponent<Rigidbody2D>();
    }
    public virtual void SetRB()
    {
        rb.gravityScale = gravity;
        GameManager.instance.LoadNextLevel();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
