using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player") 
        {
            // Update UI
            Text counter = GameObject.Find("CollectablesCounter").GetComponent<Text>();
            counter.text = (Int32.Parse(counter.text) + 1).ToString();

            // Destroy collectable
            Destroy(gameObject);
        }
    }
}
