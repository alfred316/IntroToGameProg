using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;

    private Vector3 offset;

    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");
        offset = new Vector3(0, 10, -10);
    }

    void LateUpdate()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
            offset = new Vector3(0, 10, -10);
            //offset = transform.position - player.transform.position;
        }
        transform.position = player.transform.position + offset;
    }
}
