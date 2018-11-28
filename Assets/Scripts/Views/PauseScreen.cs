using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScreen : View {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnContinueButtonClick() {
        //ViewHandler.Instance.HideCurrentView();
    }

    public void OnExitButtonClick() {
       // LoadManager.Instance.LoadScene("MainMenu");
    }
}
