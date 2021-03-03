using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : Manager
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            restart.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
