using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPositon : MonoBehaviour
{
    public Vector3 positionChange;
    public float amp = 1.0f;
    public float freq = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        positionChange = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       float newY = positionChange.y + Mathf.Sin(Time.time * freq) * amp;
       transform.position = new Vector3(positionChange.x, newY, positionChange.z);
    }
}
