using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using Button = UnityEngine.UI.Button;

public class UpdateDialogueScript : MonoBehaviour
{
    public TextMeshProUGUI dialogue;

    public Button dialogueButton;

    public Button actionButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateDialogue()
    {
        //when the button is pressed, update the text
        dialogue.text = "\nGoblin: " + "\nTHIS IS MY ROAD! SCRAM!" + "\n" +
                        "\nWell. \nYou gotta go down this road one way or another.";
        
        //set the previous button to be inactive
        dialogueButton.gameObject.SetActive(false);
        
        //set the button that goes to the next scene to be active
        actionButton.gameObject.SetActive(true);
        
    }

    //go to the next scene
    public void ActionMove()
    {
        SceneManager.LoadScene("QueueScene");
    }
}
