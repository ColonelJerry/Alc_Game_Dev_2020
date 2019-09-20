using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propellerX : MonoBehaviour
{
    public GameObject propeller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(Vector3.forward * Time.deltaTime);
    }
}
