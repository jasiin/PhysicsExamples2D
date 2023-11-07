using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rigidbod;
    int moveDir;

    void Awake()
    {
        rigidbod = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveDir = (int)Input.GetAxisRaw("Horizontal");
    }

    void FixUpdate()
    {
        rigidbod.velocity = new Vector2(moveDir, rigidbod.velocity.y);
    }

}
