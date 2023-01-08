using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{   
    private static int counter;
    public GameObject player;
    public Material activeMat;

    private Material inactiveMat;
    private bool inRange;

    private bool pressed;

    // Start is called before the first frame update
    void Start()
    {
     player = GameObject.FindWithTag("Player"); 
     inactiveMat = gameObject.GetComponent<MeshRenderer>().material;  
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange == true && pressed == false){
            if (Input.GetKeyUp(KeyCode.E)){
            Debug.Log("E key was released.");
            gameObject.GetComponent<MeshRenderer>().material = activeMat;
            counter++;
            pressed = true;
            }
        }
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag=="Player"){
            Debug.Log(pressed);
        inRange = true;
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.tag=="Player"){
            inRange = false;
        }
    }

    public int getCounter(){
        return counter;
    }
    public void setCounter(int newCounter){
        counter = newCounter;
    }
    public void setPressed(bool pressed){
        if(!pressed){
            gameObject.GetComponent<MeshRenderer>().material = inactiveMat;
            this.pressed = false;
        }
    }

    public void release(){
        setPressed(false);
    }
}
