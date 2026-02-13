using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [HideInInspector]
    public string targetScene;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(targetScene);
        if (other.tag == "player" && !string.IsNullOrEmpty(targetScene))
        {

            Debug.Log("Playerdetected        ------>>");
            SceneManager.LoadScene(targetScene);
            Debug.Log(targetScene);
        }
    }
}
