using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScroller : MonoBehaviour
{
    [SerializeField] Vector2 moveSpeed;

    Vector2 offset;
    Material material;
    void Start()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    void Update()
    {
        Vector2 offset = moveSpeed * Time.deltaTime;
        material.mainTextureOffset += offset;
    }
}
