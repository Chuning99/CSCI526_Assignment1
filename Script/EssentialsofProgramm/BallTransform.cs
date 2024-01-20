using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public Vector3 cameraOffset;
    public Transform ball;
    // Start is called before the first frame update
    void Start()
    {
        cameraOffset = ball.position - transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = ball.position - cameraOffset;
    }
}
