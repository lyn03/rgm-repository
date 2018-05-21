using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Elevate_s : MonoBehaviour {
    public int maxHeight;
    public int minHeight;
    public int timeToMove;
    public GameObject cupholder;
    public GameObject Ball2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ball2")
        {
            if (gameObject.transform.position.y < maxHeight)
            {
               
            }
        }
 
    }

}


