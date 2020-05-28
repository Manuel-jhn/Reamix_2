using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mort : MonoBehaviour
{
    public Transform teleporttarget;
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (tag == "deadzone")
        {
            Debug.Log("Tombe !");
            player.transform.position = teleporttarget.transform.position;
        }
        
    }
}
