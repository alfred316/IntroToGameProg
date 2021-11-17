using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManagerMine : MonoBehaviour
{
    public static UnityEvent newEvent;

    public delegate void NewAction();
    public static event NewAction calledAction;

    public delegate int otherNewAction(int j);
    public static event otherNewAction intAction;

    // Start is called before the first frame update
    void Start()
    {
        if (newEvent == null)
            newEvent = new UnityEvent();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Jump"))
        {
            if (calledAction != null)
            {
                calledAction();
                int i = intAction(3);
            }
        }
    }
}
