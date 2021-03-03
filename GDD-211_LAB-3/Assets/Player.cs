using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveH, moveV;
    [SerializeField] private float speed = 2.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal") * speed;
        moveV = Input.GetAxis("Vertical") * speed;
        rb.velocity = new Vector2(moveH, moveV);
    }
}
