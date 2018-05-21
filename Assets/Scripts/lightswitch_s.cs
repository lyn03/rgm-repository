using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightswitch_s : MonoBehaviour {
    public GameObject LightSwitch;
    public GameObject Ball2;
    public Light Light;

	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball2")
            Light.enabled = false;
    }
}
