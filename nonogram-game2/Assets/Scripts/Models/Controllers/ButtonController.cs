using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ButtonState{
    Opened = 0,
    Closed = 1
}

namespace Nonogram
{
    public class ButtonController : MonoBehaviour
{

    [SerializeField] private Button button;
    

    public ButtonState buttonState;
 

    public void SetButtons(){
        button.onClick.AddListener(ChangeButtonSprite);
    }

    public void ChangeButtonSprite(){
        if(buttonState == ButtonState.Opened){
            button.gameObject.transform.GetChild(1).gameObject.SetActive(true);
            buttonState = ButtonState.Closed;
        }
        else{
            button.gameObject.transform.GetChild(1).gameObject.SetActive(false);
            buttonState = ButtonState.Opened;
        }

    }

    private void SetState(ButtonState state){
        buttonState = state;
    }
    public ButtonState GetState(){
        return buttonState;
    }   
}
}

