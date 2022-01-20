using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{

    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Getting Absolute value of the horizontal input
        float h = Input.GetAxisRaw("Horizontal");
        _anim.SetFloat("Speed", Mathf.Abs(h));

        // Flip character
        if (h != 0) 
        {
            transform.localScale = new Vector3(3,3,h*3);
        }
    }
}
