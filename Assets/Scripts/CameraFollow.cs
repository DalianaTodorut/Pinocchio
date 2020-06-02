using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public Vector3 _cameraOffset;

    public float smoothSpeed = 0.5f;

    public Vector3 offset;


    private void Start()
    {
        _cameraOffset = transform.position - target.position;
    }
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + _cameraOffset;
        Vector3 smoothedPosition = Vector3.Slerp (transform.position, desiredPosition, smoothSpeed);
        
        transform.position = desiredPosition;
    }
}
