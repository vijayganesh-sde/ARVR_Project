using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PopUp : MonoBehaviour
{
    public TMPro.TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    private int index;
    void start(){
        textComponent.text=string.Empty;
        startDialogue();
    }
    // Start is called before the first frame update
    void startDialogue(){
        index=0;
        StartCoroutine(TypeLine());


    }
    IEnumerator TypeLine(){
        foreach(char c in lines[index].ToCharArray()){
            textComponent.text+=c;
            yield return new WaitForSeconds(textSpeed);
        }
        
    }
}
