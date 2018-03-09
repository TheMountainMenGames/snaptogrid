using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuController : MonoBehaviour {
    public Button ButtonHouse;
    // Use this for initialization
    void Start () {
        Button btnButtonHouse = ButtonHouse.GetComponent<Button>();
        btnButtonHouse.onClick.AddListener(TaskOnClick);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
    }
}
