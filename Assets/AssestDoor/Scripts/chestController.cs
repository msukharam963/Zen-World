using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestController : MonoBehaviour
{
    public Animator chestAnimator;
    public AudioClip chestUnlockSound;
  
    public AudioSource audioSource;

    

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Playerhjasfddsdbf;szekjf");
        if (other.tag == "player" )
            OpenChest();

    }
    void OpenChest()
    {
        chestAnimator.SetTrigger("Open");
        audioSource.PlayOneShot(chestUnlockSound);

    }
}
