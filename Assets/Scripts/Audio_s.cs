using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_s : MonoBehaviour {
    public AudioSource collisionSound;

    private void OnCollisionEnter(Collision collision)
    {
        collisionSound.Play();

    }
}
