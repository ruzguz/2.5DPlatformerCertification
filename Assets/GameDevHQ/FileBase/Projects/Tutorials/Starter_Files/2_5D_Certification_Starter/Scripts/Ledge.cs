using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ledge : MonoBehaviour
{

    [SerializeField]
    private GameObject _snapPosition;
    [SerializeField]
    private GameObject _standPosition;

    public Vector3 GetSnapPosition()
    {
        return _snapPosition.transform.position;
    }

    public Vector3 GetStandPosition()
    {
        return _standPosition.transform.position;
    }
}
