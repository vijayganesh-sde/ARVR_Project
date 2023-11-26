using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ButtonPanel : MonoBehaviour
{
    
    public GameObject panel;

    public void OpenPanel(){
        panel.SetActive(true);
    }
}
