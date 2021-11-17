using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimTest : MonoBehaviour
{
    Animator animController;

    // Start is called before the first frame update
    void Start()
    {
        animController = GetComponent<Animator>();

        EventManagerMine.newEvent.AddListener(testEventCall);
        EventManagerMine.calledAction += testEventCall;
        EventManagerMine.intAction += otherIntTest;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            EventManagerMine.newEvent.Invoke();

            animController.SetBool("triggerSpinMove", true);
            animController.SetBool("dance", true);
            
        }
        
        
    }

    private void OnDisable()
    {
        EventManagerMine.newEvent.RemoveListener(testEventCall);
        EventManagerMine.calledAction -= testEventCall;
        EventManagerMine.intAction -= otherIntTest;
    }

    public void testAnimEvent()
    {
        Debug.Log("anim event triggered");
    }

    public void testEventCall()
    {
        Debug.Log("event call triggered");
    }

    public int otherIntTest(int j)
    {
        int i = 5;
        int result = i + j;
        Debug.Log("result of int event: " + result);
        return result;
    }
}
