using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_s : MonoBehaviour
{
    public GameObject Ball2 = null;
    public GameObject TeleportPad = null;
    public GameObject TeleportPad2 = null;
    private bool startTP = false;

    private void OnCollisionEnter(Collision collider)
    {
        if (startTP == true)
        {
            Vector3 position = TeleportPad2.gameObject.transform.position;
            position.y += 2;
            Ball2.gameObject.transform.position = position;
        }

        {
            if (collider.gameObject.name == "TeleportPad")
                startTP = true;
            else
                startTP = false;
        }
    }
}


