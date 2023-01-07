using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class torTrigger : MonoBehaviour
{
    private GameObject button;
    public int buttonAmount;

    [SerializeField] private Animator openTor = null;
    private int transLateDuration;
    ButtonScript buttonScript;
    // Start is called before the first frame update
    void Start()
    {
        buttonScript = FindObjectOfType<ButtonScript>().GetComponent<ButtonScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(buttonScript.getCounter() == buttonAmount){
            buttonScript.setCounter(0);
            openTor.Play("TorTrigger", 0, 0.0f);
        }
    }
    void release(){
        ButtonScript[] buttonScripts = FindObjectsOfType<ButtonScript>();
        foreach(ButtonScript bs in buttonScripts){
            bs.release();
        }
    }

}
