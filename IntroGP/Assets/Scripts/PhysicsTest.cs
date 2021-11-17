using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    private Rigidbody rb;
    //public GameObject anchor;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * 50;
        float v = Input.GetAxis("Vertical") * 50;

        rb.AddTorque(transform.up * h);
        rb.AddTorque(transform.right * v);
    }

}
