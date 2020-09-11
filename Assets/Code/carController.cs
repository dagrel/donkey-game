using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{

    public bool isTurned;
    public float positionA;
    public float positionB;


    // using space to move car      
    void Update()
    {
        // if space is pushed 
        if (Input.GetKeyDown("space"))
        {
            isTurned = !isTurned;

            if (isTurned)
            {
                // set x positionA w/o changing y and z pos.
                transform.position = new Vector3(positionA, transform.position.y, transform.position.z);
            }
            else
            {
                // set x pos to posA, w/o changing y and z
                transform.position = new Vector3(positionB, transform.position.y, transform.position.z);
            }
        }
    }

    private void OnTriggerEnter()
    {
        GameObject.Find("Game").GetComponent<gameController>().gameOver = true;
    }
}
