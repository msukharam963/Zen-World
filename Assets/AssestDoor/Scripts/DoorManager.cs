using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class DoorManager : MonoBehaviour
{
    public Animator doorAnimator;
    public AudioClip doorUnlockSound;
    public LevelLoader sceneChangeTrigger; 


    private Collider keySocketCollider;
    private AudioSource audioSource;

    void Start()
    {
        // Get a reference to the collider on this object (the KeySocket)
        keySocketCollider = GetComponent<Collider>();
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        string sceneToLoad = "";

        if (other.tag == "Vangogh" || other.tag == "NorthernLights" || other.tag == "zenGarden")
            OpenDoor();


        //Load Scene
        if (other.tag == "Vangogh")
        {
            sceneToLoad = "Vangogh";
        }
        else if (other.tag == "NorthernLights")
        {
            sceneToLoad = "NorthernLights";
        }
        else if (other.tag == "zenGarden")
        {
            sceneToLoad = "zenGarden";
        }

        sceneChangeTrigger.targetScene = sceneToLoad;
        Debug.Log(sceneToLoad);

    }
    void OpenDoor()
    {
        doorAnimator.SetTrigger("Open");
        keySocketCollider.enabled = false;

        audioSource.PlayOneShot(doorUnlockSound);

    }
}
