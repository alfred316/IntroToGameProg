using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    public class Inventory
    {

        public int bullets;
        public int grenades;
        public int rockets;
        public float fuel;

        public Inventory(int bul, int gre, int roc)
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }

        public Inventory(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }

        // Constructor
        public Inventory()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }

    }

    public Inventory myInventory = new Inventory(10, 7, 25);
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;


    [Range(1,10)]
    public float speed = 5;

    [Range(50, 80)]
    public float turnSpeed = 70;

    public bool inTrigger;

    public GameObject spotLight;

    public float t;

    public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        inTrigger = false;
        t = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Shoot();

        /*
        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(- Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.F) && inTrigger)
        {
            spotLight.SetActive(!spotLight.activeInHierarchy);
            /*
            if (!GameObject.FindGameObjectWithTag("LightPost").GetComponent<LightHandler>().lightSource.activeInHierarchy)
            {
                GameObject.FindGameObjectWithTag("LightPost").GetComponent<LightHandler>().lightSource.SetActive(true);
            }
            else if(GameObject.FindGameObjectWithTag("LightPost").GetComponent<LightHandler>().lightSource.activeInHierarchy)
            {
                GameObject.FindGameObjectWithTag("LightPost").GetComponent<LightHandler>().lightSource.SetActive(false);
            }
            
        }
    */

        //float horizontalInput = Input.GetAxis("Horizontal");
        //Get the value of the Horizontal input axis.

        //float verticalInput = Input.GetAxis("Vertical");
        //Get the value of the Vertical input axis.

        //transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);
        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.
        //controller.Move(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);
        //transform.position = new Vector3(Mathf.LerpUnclamped(transform.position.x, spotLight.transform.position.x, t), 
        //0, Mathf.Lerp(transform.position.z,spotLight.transform.position.z,0.8f));

        
        /*
        if (Input.GetButton("Fire1"))
        {
            Debug.Log("pressed fire1");
            Component.FindObjectOfType<CameraHandler>().test = true;
        }

        if (Input.GetButton("Fire2"))
        {
            Debug.Log("pressed fire2");
            Component.FindObjectOfType<CameraHandler>().test = false;
        }

        if (Input.GetButton("Fire1"))
        {
            Debug.Log("pressed fire1");
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraHandler>().test = true;
        }

        if (Input.GetButton("Fire2"))
        {
            Debug.Log("pressed fire2");
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraHandler>().test = true;
        }
        */
        /*
        if (Input.GetButton("Fire1"))
        {
            Debug.Log("pressed fire1");
            CameraHandler.staticTest = true;
        }

        if (Input.GetButton("Fire2"))
        {
            Debug.Log("pressed fire2");
            CameraHandler.staticTest = false;
        }
        */
    }

    //float horizontalInput = Input.GetAxis("Horizontal");
    //Get the value of the Horizontal input axis.

    //float verticalInput = Input.GetAxis("Vertical");
    //Get the value of the Vertical input axis.

    //transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * speed * Time.deltaTime);

    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }

    void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && myInventory.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myInventory.bullets--;
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("trigger: " + other);
        if (other.name.Contains("Light"))
        {
            inTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("trigger: " + other);
        if (other.name.Contains("Light"))
        {
            inTrigger = false;
        }
    }
}
