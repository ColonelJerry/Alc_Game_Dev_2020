using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planegame : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    private bool engine=false;
    public float acceleration;
    public float maxSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            engine = !engine;
        }
        if (engine == true)
        {
            transform.Translate(Vector3.forward, acceleration * Time.deltaTime, 0);
            if (acceleration < maxSpeed)
            {
                acceleration += 0.25f;
            }
        }

    

            // get the user's vertical input
            verticalInput = Input.GetAxis("Vertical");

            //get the user's horizontal input
            horizontalInput = Input.GetAxis("Horizontal");

            // tilt the plane up/down based on up/down arrow keys
            transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

            // tilt the plane left/right based on left/right arrow keys
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime * horizontalInput);
        }
    }
