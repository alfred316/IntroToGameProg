using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayerManager : MonoBehaviour
{
    CharacterController controller;

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        float verticalInput = Input.GetAxis("Vertical");
        //Get the value of the Vertical input axis.

        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.
        controller.Move(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);
    }


    public void SetInt()
    {
        PlayerPrefs.SetInt("test", 3);
        PlayerPrefs.Save();
    }

    public void Getint()
    {
        if(PlayerPrefs.HasKey("test"))
        {
            int i = PlayerPrefs.GetInt("test");
            Debug.Log("playerprefs test: " + i);
        }
    }
}
