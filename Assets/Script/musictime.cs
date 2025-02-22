using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musictime : MonoBehaviour
{
    public AudioSource audioSource;
    public float delay = 3.0f;

    private float timer = 0.0f;
    private bool isDelayed = false;


    // Update is called once per frame
    void Update()
    {
        if (!isDelayed)
        {
            timer += Time.deltaTime;
            if (timer >= delay)
            {
                audioSource.Play();
                isDelayed = true;
            }
        }
    }
}
