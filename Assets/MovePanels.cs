using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePanels : MonoBehaviour {
    public GameObject selectionPanel;
    public GameObject displayPanel;
    public GameObject selectionScrollView;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onClick() {
        selectionPanel.SetActive(false);
        displayPanel.SetActive(true);
        selectionScrollView.SetActive(false);
    }
}
