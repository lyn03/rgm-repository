using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_s : MonoBehaviour {
    public float speed = .55f; 
    // The speed of the rotation is set here
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, speed, 0);
        // Speed set rotates around the y axis
	}
}
