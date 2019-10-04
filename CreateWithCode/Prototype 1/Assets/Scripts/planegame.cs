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
            // move the plane forward at a constant rate
            transform.Translate(Vector3.forward * speed);
            
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
