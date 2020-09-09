using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Control : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 north, south, east, west, up, down;
    // Start is called before the first frame update
    void Start()
    {    
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerTransform.position = playerTransform.position + north;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            playerTransform.position = playerTransform.position + south;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerTransform.position += west;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerTransform.position += east;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerTransform.position += up;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            playerTransform.position += down;
        }

    }
}
