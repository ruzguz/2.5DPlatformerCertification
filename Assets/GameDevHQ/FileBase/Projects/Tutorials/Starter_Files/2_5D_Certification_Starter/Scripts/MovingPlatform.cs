using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    // Positions
    private Vector3 _pointA, _pointB, currentTarget;

    // General Vairables
    [SerializeField]
    private float _speed = 5.0f;
    private float step;

    // Start is called before the first frame update
    void Start()
    {
        _pointA = gameObject.transform.Find("PointA").transform.position;
        _pointB = gameObject.transform.Find("PointB").transform.position;
        currentTarget = _pointA;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == _pointA) 
        {
            currentTarget = _pointB;
        } 

        if (transform.position ==  _pointB) 
        {
            currentTarget = _pointA;
        }

        step = Time.deltaTime * _speed;
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, step);
    }
}
