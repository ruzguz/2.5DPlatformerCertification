using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Player Variables
    [SerializeField]
    private float _speed = 8f;
    [SerializeField]
    private float _jumpHeight = 20f;
    [SerializeField]
    private float _gravity = 0.5f;
    private Vector3 _direction;
    private Vector3 _velocity;
    private float _yVelocity;

    // Component Handlers
    private CharacterController _controller;
    private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        if (_controller == null) 
        {
            Debug.LogError("Character Controller is null");
        }

        _anim = GetComponentInChildren<Animator>();
        if (_anim == null) 
        {
            Debug.LogError("Animator is null");
        }
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        _direction = new Vector3(0, 0, h);
        _velocity = _direction * _speed;

        if (_controller.isGrounded == true) 
        {
            _anim.SetBool("Jump", false);
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                _anim.SetBool("Jump", true);
                _yVelocity = _jumpHeight;
            }
        } else 
        {
            _yVelocity -= _gravity;
        }


        _velocity.y = _yVelocity;
        _controller.Move(_velocity * Time.deltaTime);
    }

    public void GrabLedge()
    {
        _anim.SetBool("GrabLedge", true);
        _controller.enabled = false;
    }
}
