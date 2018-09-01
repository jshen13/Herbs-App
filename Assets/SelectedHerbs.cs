using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SelectedHerbs : MonoBehaviour {
    public Toggle[] checks;
    private ArrayList names;
    public Text displayHerbsName;
    public Text displayHerbsPlace;
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

        

        names = new ArrayList();
        foreach (Toggle c in checks)
        {
            if (c.isOn)
            {
                names.Add(c.name);
            }


        }
        string herbName = "";
        string herbPlace = "";
        Debug.Log(names.ToString());

        int index;
        foreach (string n in names){
            int.TryParse(n, out index);
            Debug.Log(index);
            herbName += allHerbs[index] + "\n";
            herbPlace += location[index] + "\n";
            Debug.Log(location[index]);
        }
        displayHerbsName.text = herbName;
        displayHerbsPlace.text = herbPlace;
    }
}
