using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LedgeGrabChecker : MonoBehaviour
{

    [SerializeField]
    Player player;

    void OnTriggerEnter(Collider other) {

        if (other.tag == "Ledge") 
        {
            player.GrabLedge();
            player.transform.position = other.GetComponent<Ledge>().GetSnapPosition();
            player.standPosition = other.GetComponent<Ledge>().GetStandPosition();
        }
    }
}
