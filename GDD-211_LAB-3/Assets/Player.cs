using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public Animator anim;

    private float moveH, moveV;
    [SerializeField] private float speed = 2.0f;

    public GameObject restart;
    public GameObject exit;
    public GameObject exitText;

    private int score;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        anim.SetFloat("Horizontal", moveH);
        anim.SetFloat("Vertical", moveV);
        anim.SetFloat("Speed", speed);

        if (score == 4)
        {
            exitText.SetActive(true);
            exit.SetActive(true);
        }

    }

    private void FixedUpdate()
    {
        moveH = Input.GetAxis("Horizontal") * speed;
        moveV = Input.GetAxis("Vertical") * speed;
        rb.velocity = new Vector2(moveH, moveV);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            restart.SetActive(true);
            Destroy(gameObject);

        }

        if (collision.tag == "Gem")
        {
            Destroy(collision.gameObject);
            score++;
        }
    }
}
