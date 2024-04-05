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
        dialogue.text = "\nGoblin: " + "'GOODBYE! \nNONE SHALL PASS LEST YOU SOLVE MY RIDDLE! \nGOOD TIDINGS!'" +
                        "\nWell. \nYou gotta go down this road one way or another.";
        
        dialogueButton.gameObject.SetActive(false);
        actionButton.gameObject.SetActive(true);
        
    }

    public void ActionMove()
    {
        SceneManager.LoadScene("QueueScene");
    }
}
