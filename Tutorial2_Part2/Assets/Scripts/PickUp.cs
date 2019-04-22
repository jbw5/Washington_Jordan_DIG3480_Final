using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public AudioClip musicClipThree;
    public AudioSource musicSource2;

     void Start()
    {
        musicSource2 = GetComponent<AudioSource>();
            
    }

    //void OnTriggerEnter2D(Collider2D knight)
    //{
    //if (knight.gameObject.CompareTag("Knight"))
    // {
    // AudioSource musicScource2 = GetComponent<AudioSource>();
    // musicSource2.clip = musicClipThree;

    // musicSource2.Play();


    //   }


    // }

    void OnTriggerEnter(Collider PickUp)
    {
        if (PickUp.gameObject.tag == "Knight")
        {
            musicSource2.clip = musicClipThree;
            musicSource2.Play();
        }
    }

}
