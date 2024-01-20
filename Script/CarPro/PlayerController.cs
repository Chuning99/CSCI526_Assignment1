using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f; //Speed of the vehicle
    private float turnSpeed = 45.0f; //Turning speed of the vehicle
    private float horizontalInput; //Horizontal input from the player
    private float forwardInput; //Vertical input from the player
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {        
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //Move the vehicle forward
        transform.Translate(Vector3.forward* Time.deltaTime * speed * forwardInput);
        //transform.Translate(Vector3.right* Time.deltaTime * turnSpeed * horizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput * forwardInput);

    }
}
