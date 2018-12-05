using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : View {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnRetryButtonClick() {
        //LoadManager.Instance.LoadScene("ShootingTest");
        ViewHandler.Instance.Show("tutorial");
    }

    public void OnExitButtonClick() {
        LoadManager.Instance.LoadScene("MainMenu");
    }
}
