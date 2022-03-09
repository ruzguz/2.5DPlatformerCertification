using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    // Way Points
    [SerializeField]
    private Transform _pointA, _pointB;

    [SerializeField]
    private GameObject _elevatorFloor;

    // General variables 
    [SerializeField]
    private float _speed;
    [SerializeField]
    private bool _moveUp = false;
    [SerializeField]
    private float _delay = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoveElevator());
    }

    private IEnumerator MoveElevator()
    {
        while (true) 
        {
            // Calculate path
            if (_elevatorFloor.transform.position.y <= _pointB.position.y) 
            { 
                yield return new WaitForSeconds(_delay);
                _moveUp = true;
            }

            if (_elevatorFloor.transform.position.y >= _pointA.position.y) 
            {
                yield return new WaitForSeconds(_delay);
                _moveUp = false;
            }

            int path = _moveUp == true ? 1:-1;

            // Move the floor
            _elevatorFloor.transform.Translate(0, _speed * path * Time.deltaTime, 0);
            yield return new WaitForEndOfFrame();
        }
    }

}
