using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Devil : Enemy
{
    private float moveRate = 2.0f;
    private float moveTimer;

    [SerializeField] private float minX, maxX, minY, maxY;

    protected override void Move()
    {
        //base.Move();
        RandomMove();
    }

    private void RandomMove() 
    {
        moveTimer += Time.deltaTime;

        if (moveTimer > moveRate)
        {
            transform.position = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), 0);
            moveTimer = 0;
        }
    }
}
