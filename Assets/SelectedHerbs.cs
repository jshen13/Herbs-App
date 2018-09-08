using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectedHerbs : MonoBehaviour {
    public Toggle[] group1Checks;
    public GameObject[] fields;
    private ArrayList names;
    public Text displayHerbsName;
    public Text displayHerbsPlace;
    int counter = 0; //counts how many herbs are selected
    private string[] allHerbs = {"herb 1", "herb 2", "herb 3", "herb 4",
                                 "herb 5", "herb 6", "herb 7", "herb 8"};
    private string[] location = {"1, 1", "1, 2", "1, 3", "1, 4",
                                 "2, 1", "2, 2", "2, 3", "2, 4" };
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
       
	}

    public void display()
    {

        

        names = new ArrayList(); //names is the arraylist that contains all the selected herbs
        foreach (Toggle c in group1Checks)
        {
            if (c.isOn)
            {
                names.Add(c.name); //adds the herb to the arraylist names if it is selected
                counter++; //counts the number of selectedf

            }


        }
        string herbName = ""; //instantiate string for printing the names
        string herbPlace = "";  // instantiate string for printing the places of the herbs

        int index;  
        foreach (string n in names){  //loops through all the selected herbs
            int.TryParse(n, out index); //each toggle is assigned an index which corresponds to which herb it is
            herbName += allHerbs[index] + "\n"; //update the name list
            herbPlace += location[index] + "\n"; //update the place list
        }
        displayHerbsName.text = herbName; //set the string to the textbox
        displayHerbsPlace.text = herbPlace; //set the place string to the text box

        for (int i = 0; i < counter; i++){
            fields[i].SetActive(true);
        }
    }
}
