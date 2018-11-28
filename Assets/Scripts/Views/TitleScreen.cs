using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : View {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnStartButtonClick() {
        Debug.Log("*Start*");
        //Load the next scene when start button is clicked
        //LoadManager.Instance.LoadScene("");
    }

    public void OnExitButtonClick() {
        Debug.Log("*Exit*");
        //Application.Quit();
    }
}
