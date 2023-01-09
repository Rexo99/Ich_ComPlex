using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToMatrixScirpt : MonoBehaviour
{
    private float startTime = 0f;
    private float holdTime = 3.0f;

    private bool switched;
    public CharacterController controller;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            startTime = Time.time;
        } else if (Input.GetKey(KeyCode.E)){
            if(Time.time - startTime > holdTime){
                startTime = float.PositiveInfinity;
                if(switched == false){
                switchWorld();
                }
            }
        } else {
            startTime = float.PositiveInfinity;
        }
    }
    private void switchWorld(){
        controller.enabled = false;
                transform.position = new Vector3(-transform.position.x,transform.position.y,transform.position.z);
                switched = true;
                controller.enabled = true;
    }
}
