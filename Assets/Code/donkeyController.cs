using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donkeyController : MonoBehaviour
{
    // variable for speed of donkey
    public float speed;

    
    void Start()
    {
        // set speed
        speed = 0.5F;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);

        // check if donkey is out of picture - if so remove from scene
        if (transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}
