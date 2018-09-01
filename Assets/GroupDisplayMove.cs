using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupDisplayMove : MonoBehaviour {
    public GameObject GroupSelectionPanel;
    public GameObject DisplayPanel;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void groupToDisplayMove(){
        GroupSelectionPanel.SetActive(false);
        DisplayPanel.SetActive(true);
    }

    public void displayToGroupMove()
    {
        GroupSelectionPanel.SetActive(true);
        DisplayPanel.SetActive(false);
    }
}
