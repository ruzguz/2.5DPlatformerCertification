using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Player Variables
    [SerializeField]
    private float _speed = 0.5f;
    [SerializeField]
    private float _jumpHeight = 2.0f;
    [SerializeField]
    private float _gravity = 0.1f;
    private Vector3 _direction;
    private Vector3 _velocity;
    private float _yVelocity;

    // Component Handlers
    private CharacterController _controller;


    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        if (_controller == null) 
        {
            Debug.LogError("Character Controller is null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        _direction = new Vector3(0, 0, h);
        _velocity = _direction * _speed;

        if (_controller.isGrounded == true) 
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                _yVelocity = _jumpHeight;
            }
        } else 
        {
            _yVelocity -= _gravity;
        }


        _velocity.y = _yVelocity;
        _controller.Move(_velocity);
        

    }
}
