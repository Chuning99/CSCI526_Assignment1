using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; //Reference to the player object
    private Vector3 offset = new Vector3(0, 8, -25); //Offset of the camera from the player
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position=player.transform.position + offset;
        
    }
}
