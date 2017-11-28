using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    //Object camera will follow to followTarget object
    [SerializeField]
    private GameObject followTarget;
    //How far camera stays from target
    private Vector3 followDistance;

    /// <summary>
    /// Start this instance.
    /// </summary>
    private void Start ()
    {
        followDistance = transform.position - followTarget.transform.position;
    }

    /// <summary>
    /// Update this instance.
    /// </summary>
    private void Update ()
    {
        transform.position = followTarget.transform.position + followDistance;
    }
}
