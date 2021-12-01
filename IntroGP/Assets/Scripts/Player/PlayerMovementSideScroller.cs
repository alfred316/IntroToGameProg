using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementSideScroller : MonoBehaviour
{

    Rigidbody rb;
    public float buttonTime = 0.3f;
    public float jumpAmount = 5;
    float jumpTime;
    bool jumping;

    public float movespeed = 10;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jumping = true;
            jumpTime = 0;
        }

        if (jumping)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpAmount);
            jumpTime += Time.deltaTime;
        }

        if (Input.GetKeyUp(KeyCode.Space) | jumpTime > buttonTime)
        {
            jumping = false;
        }
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        transform.Translate(new Vector3(h, 0, 0) * movespeed * Time.deltaTime);
    }
}
