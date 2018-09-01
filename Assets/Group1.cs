using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group1 : MonoBehaviour {

    public GameObject groupSelectionPanel;
    public GameObject G1HerbSelectionPanel;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void onClick()
    {
        groupSelectionPanel.SetActive(false);
        G1HerbSelectionPanel.SetActive(true);
    }
    public void backButton(){
        groupSelectionPanel.SetActive(true);
        G1HerbSelectionPanel.SetActive(false);
    }
}
