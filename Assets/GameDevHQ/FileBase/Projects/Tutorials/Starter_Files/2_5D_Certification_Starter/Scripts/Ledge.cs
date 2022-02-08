using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ledge : MonoBehaviour
{

    [SerializeField]
    private GameObject _snapPosition;

    public Vector3 GetSnapPosition()
    {
        return _snapPosition.transform.position;
    }
}
