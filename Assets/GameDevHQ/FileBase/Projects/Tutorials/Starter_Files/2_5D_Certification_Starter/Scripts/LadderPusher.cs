using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderPusher : MonoBehaviour
{
    [SerializeField]
    private float _force = 20.0f;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player") 
        {
            Debug.Log("Ladder Pusher");
            other.GetComponent<Player>().PushByLadder(_force);
        }
    }
}
