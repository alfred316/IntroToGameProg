using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    /*
    private void OnMouseDown()
    {

        GetComponent<Rigidbody>().AddForce(-transform.forward * 500);
        GetComponent<Rigidbody>().useGravity = true;
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Enter collider: " + collision.transform.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Stay collider: " + collision.transform.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Exit collider: " + collision.transform.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Enter trigger: " + other.transform.name);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Stay trigger: " + other.transform.name);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Exit trigger: " + other.transform.name);
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal") * 50 * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * 50 * Time.deltaTime;

        GetComponent<Rigidbody>().AddTorque(transform.up * h);
        GetComponent<Rigidbody>().AddTorque(transform.right * v);
    }
    */

    private void Update()
    {
        RaycastHit hit;
        Ray hitRay = new Ray(transform.position, Vector3.forward);
        Debug.DrawRay(transform.position, Vector3.forward);
        if(Physics.Raycast(hitRay, out hit))
        {
            Debug.Log("we hit: " + hit.transform.name);
        }
    }

}
