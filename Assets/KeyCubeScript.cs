using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCubeScript : MonoBehaviour
{
    public Material activateMat;
    private static bool missionPassed;
    private Material inactiveMat;
    private GameObject player;
    private bool pressed;
    private static int counter;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        inactiveMat = gameObject.GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == 3){
            missionPassed = true;
        }
    }
    public bool getMissionPassed(){
        return missionPassed;
    }
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="KeyCube"){
            pressed = true;
            gameObject.GetComponent<MeshRenderer>().material = activateMat;
            other.gameObject.GetComponent<MeshRenderer>().material = activateMat;
            counter++;
        }   
    }
        private void OnCollisionExit(Collision other) {
        if(other.gameObject.tag=="KeyCube"){
            pressed = false;
            gameObject.GetComponent<MeshRenderer>().material = inactiveMat;
            other.gameObject.GetComponent<MeshRenderer>().material = inactiveMat;
            counter--;
        }   
    }
}
