using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hatcollection : MonoBehaviour
{
    public float speed = 5f;
    public float xMin;
    public float xMax;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;
        float input = Input.GetAxis("Horizontal");
        position.x += speed * input * Time.deltaTime;
       

        position.x = Mathf.Clamp(position.x, -8f, 8f); 
        transform.position = position;
    }
}
