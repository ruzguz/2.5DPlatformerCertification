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
    private float _gravity = 0.05f;
    private Vector3 _direction;
    private Vector3 _velocity;

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

        

        _controller.Move(_velocity);
        

    }
}
