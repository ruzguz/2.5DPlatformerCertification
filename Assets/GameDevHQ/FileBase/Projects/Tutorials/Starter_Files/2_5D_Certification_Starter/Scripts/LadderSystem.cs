using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderSystem : MonoBehaviour
{
    private void OnTriggerStay(Collider other) 
    {
        if (other.tag == "Player") 
        {
            if (Input.GetAxisRaw("Vertical") != 0) 
            {
                other.GetComponent<Player>().ClimbLadder();
            }
            
            if (Input.GetAxisRaw("Horizontal") != 0) 
            {
                other.GetComponent<Player>().LeaveLadder();
            }
        } 
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player") 
        {
            other.GetComponent<Player>().LeaveLadder();
        }
    }
}
