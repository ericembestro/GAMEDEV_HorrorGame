using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private int life;
    [SerializeField] private AudioSource voice;
    [SerializeField] private TextMesh lifedisplay;
    private float playertime;
    [SerializeField] private TextMesh timedisplay;

	// Use this for initialization
	void Start () {
        //voice = GetComponent<AudioSource>();
        //voice.Play(0);
        life = 100;
        playertime = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
        if (life > 0) {
            lifedisplay.text = "Life: " + life.ToString();
            if (Input.GetKeyDown(KeyCode.Space)) {
                voice.Play();
                life -= 50;
            }
            playertime += Time.deltaTime;
            timedisplay.text = "Time: " + playertime.ToString("F2");
        }
        else {
            //LoadManager.Instance.LoadScene("ShootingTest");
            ViewHandler.Instance.Show("GameOverScreen");
        }
	}
}
