using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private int life;
    [SerializeField] private AudioSource voice;
    [SerializeField] private TextMesh lifedisplay;
    

	// Use this for initialization
	void Start () {
        //voice = GetComponent<AudioSource>();
        //voice.Play(0);
        life = 100;
        
	}
	
	// Update is called once per frame
	void Update () {
        if (life > 0) {
            lifedisplay.text = life.ToString();
            if (Input.GetKeyDown(KeyCode.Space)) {
                voice.Play();
                life -= 50;
            }
        }
        else LoadManager.Instance.LoadScene("ShootingTest");
        
	}
}
