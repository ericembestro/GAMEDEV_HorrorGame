using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("BANG!");
            GetComponent<Animation>().Play();
            GetComponent<AudioSource>().Play();
        }
    }
}
