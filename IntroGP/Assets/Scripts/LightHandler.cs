using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHandler : MonoBehaviour
{

    public GameObject lightSource;

    public bool lightToggle;

    // Start is called before the first frame update
    void Start()
    {
        lightToggle = false;
        /*
        if(lightSource.activeInHierarchy)
        {
            lightSource.SetActive(false);
        }
        */
        
    }

    // Update is called once per frame
    void Update()
    {
        lightSource.GetComponent<Light>().intensity = Mathf.Lerp(lightSource.GetComponent<Light>().intensity, 8f, 0.5f * Time.deltaTime);
        /*
        if (lightToggle)
        {
            if(!lightSource.activeInHierarchy)
            {
                lightSource.SetActive(true);
            }
        }
        else if(!lightToggle)
        {
            if(lightSource.activeInHierarchy)
            {
                lightSource.SetActive(false);
            }
        }
        */
    }
}
