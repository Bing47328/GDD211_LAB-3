using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject restart;


    public void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }





}
