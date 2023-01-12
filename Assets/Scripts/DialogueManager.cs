using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogText;
    public Animator animator;

    private Queue<string> saetze;
    private bool dialogStarted;


    void Start()
    {
        saetze = new Queue<string>();
    }
    private void Update() {
        if(dialogStarted)
        if(Input.GetKeyDown(KeyCode.Space)){
            DisplayNextSentence();
        }    
    }
    public void startDialog(Dialog dialog){
        animator.SetBool("isOpen", true);
        dialogStarted = true;
        saetze.Clear();
        nameText.text = dialog.npcName;
        foreach(string item in dialog.saetze){
            saetze.Enqueue(item);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence(){
        if(saetze.Count == 0){
            EndDialog();
            return;
        }
        string satz = saetze.Dequeue();
        dialogText.text = satz;
    }
void EndDialog()
{   animator.SetBool("isOpen", false);
    dialogStarted = false;
    Debug.Log("Ende im Gelände");
}

}
