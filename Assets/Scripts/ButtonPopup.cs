using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonPopup : MonoBehaviour
{
    
    public TMPro.TextMeshPro textcomponent;

    // The text you want to display in the dialogue box
    public string dialogueText = "This is your dialogue text.";

    // This function is called when the clickable text is clicked
    public void OnClick()
    {
        // Show the dialogue box
        textcomponent.enabled = true;

        // Set the dialogue text
        // You might want to replace this with a more dynamic method
        textcomponent.text = dialogueText;
    }

    // This function is called when the dialogue box is closed
    public void CloseDialogue()
    {
        // Hide the dialogue box
        textcomponent.enabled = false;
    }

}

