using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private string enemyName;
    [SerializeField] private float moveSpeed;
    private float hp;
    [SerializeField] private float maxhp;
    private Transform target;

    [SerializeField] private float radius;
    private SpriteRenderer sp;


    private void Start()
    {
        hp = maxhp;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        sp = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        Move();
        Turn();
    }

    private void Move()
    {
        if (Vector2.Distance(transform.position, target.position) < radius)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
        }
    }

    private void Turn()
    {
        if (transform.position.x > target.position.x)
        {
            sp.flipX = true;
        }
        else
        {
            sp.flipX = false;
        }
    }

}
