using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    protected private int score;

    public GameObject restart;

    public GameObject exit;

    private void Update()
    {
        if (score == 3)
        {
            exit.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }





}
