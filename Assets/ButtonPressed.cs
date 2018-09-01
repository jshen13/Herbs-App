using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressed : MonoBehaviour {
    public Button button;
    public Toggle buttonToggle;
    public Color selectedColor;
    public Color notSelectedColor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //when the button is clicked
    public void onClick()
    {
        ColorBlock cb = button.colors;

        if (buttonToggle.isOn)
        {
            buttonToggle.isOn = false;
            //cb.normalColor = notSelectedColor;
            //cb.highlightedColor = notSelectedColor;
            //button.image.color = notSelectedColor;
            //button.colors = cb;
        }
        else 
        {
            buttonToggle.isOn = true;
            //cb.normalColor = selectedColor;
            //cb.highlightedColor = selectedColor;
            //button.colors = cb;
        }
    }

    
}
