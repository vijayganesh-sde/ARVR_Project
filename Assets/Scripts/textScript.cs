using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class textScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TMPro.TextMeshPro text1;
    public string description;
    public string res = "";
    public void Start()
    {
        res = text1.text;

}
    
    private void OnTriggerStay()
    {
        
        text1.text = description;
        text1.enabled = true;
    }

    private void OnTriggerExit()
    {
        text1.text=res;
    }
}
