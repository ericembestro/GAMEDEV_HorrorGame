using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial2Script : MonoBehaviour {

    [SerializeField] private Texture[] images;
    int imageLength;
    int currentImage = 0;
    bool isChanged;
    [SerializeField] private RawImage displayedPic;

	// Use this for initialization
	void Start () {
        imageLength = images.Length;
        displayedPic.texture = images[currentImage];
	}
	
	// Update is called once per frame
	void Update () {
		if (isChanged) {
            currentImage = currentImage % imageLength;
            displayedPic.texture = images[currentImage];
            isChanged = false;
        }
	}

    public void onNextButtonClick() {
        currentImage++;
        isChanged = true;
    }

    public void onBackButtonClick() {
        currentImage--;
        isChanged = true;
    }

    public void onPlayButtonClick() {
        LoadManager.Instance.LoadScene("ShootingTest");
    }
}
