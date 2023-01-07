using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPillarScript : MonoBehaviour
{   
    [SerializeField] private Animator activatePillarCollection = null;
    private GameObject keyCube;
    private KeyCubeScript keyCubeScript;

    private bool pillarActivated;
    // Start is called before the first frame update
    void Start()
    {
        keyCubeScript = FindObjectOfType<KeyCubeScript>().GetComponent<KeyCubeScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!pillarActivated){
        if(keyCubeScript.getMissionPassed() == true){
            pillarActivated = true;
            activatePillarCollection.Play("ButtonPillarCollection", 0, 0.0f);
        }
        }
    }
}
