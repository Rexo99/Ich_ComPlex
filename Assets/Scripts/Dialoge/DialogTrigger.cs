using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public Dialog dialog;

    private void OnTriggerStay(Collider other) {
        if(other.tag == "Player"){
            if(Input.GetKeyDown(KeyCode.E)){
                FindObjectOfType<DialogueManager>().startDialog(dialog);
            }
        }
    }
}
