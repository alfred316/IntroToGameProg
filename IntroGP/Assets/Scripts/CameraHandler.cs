using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{


    public Transform target;

    public bool test;
    
    
    static public bool staticTest;
    // Start is called before the first frame update
    void Start()
    {
        test = false;
    }
    void Update()
    {
        transform.LookAt(target);

        if(staticTest)
        {
            test = true;
        }
        if(!staticTest)
        {
            test = false;
        }
    }
    private void LateUpdate()
    {
        transform.position = new Vector3(target.transform.position.x, target.transform.position.y + 25, target.transform.position.z - 25);
    }
}
