using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

    [SerializeField] private Text timetext;
    private float timevalue;

	// Use this for initialization
	void Start () {
        timevalue = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        timevalue += Time.deltaTime;
        timetext.text = timevalue.ToString("F3");
	}
}
