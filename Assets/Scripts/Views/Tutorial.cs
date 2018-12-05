using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : View {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void onNoButtonClick() {
        LoadManager.Instance.LoadScene("ShootingTest");
    }

    public void onYesButtonClick() {
        ViewHandler.Instance.Show("Tutorial2");
    }
}
