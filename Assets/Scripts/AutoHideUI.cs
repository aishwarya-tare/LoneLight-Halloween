using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class AutoHideUI : MonoBehaviour
{
    private string input;
    public GameObject scanRoom;
    public GameObject riddle;

    public void Start() {

    }
    private void Update() {
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
            //uiSystem.SetActive(true);
            riddle.SetActive(true);
            CancelInvoke("HideUISystem");
        }                                           
        else {
            Invoke("HideUISystem", 5);
        }
    }

    void HideUISystem() {
        // uiSystem.SetActive(false);
        riddle.SetActive(false);
    }
}
