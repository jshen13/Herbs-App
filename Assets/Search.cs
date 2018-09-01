using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Search : MonoBehaviour {
    public List<GameObject> Buttons = new List<GameObject>();
    public InputField input;

    //On input field text changed:

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (input == null || input.text.Equals("")){
            foreach (GameObject b in Buttons)
            {
                b.SetActive(false);
            }
        }
        else
        {
            foreach (GameObject b in Buttons)
            {
                //  if (!b.ToString.Equals())
                //  {
                //hide buttons that don't contain the input.
                //  }
                if (b.name.Contains(input.text)){
                    b.SetActive(true);
                }

                    
                
            
            
            }
        }
    }
}
