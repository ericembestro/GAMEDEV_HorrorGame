using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour {
    [SerializeField] private Animator GunAnimator;
    private const string SHOOT_KEY = "Shooting";
    private AudioSource bangSound;
    private Light muzzleFlash;
    void Start () {
        bangSound = GetComponent<AudioSource>();
        muzzleFlash = GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("BANG!");
            this.GunAnimator.SetBool(SHOOT_KEY, true);
            bangSound.loop = true;
            bangSound.Play();
            muzzleFlash.enabled = true;
        }
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("STOP BANG!");
            bangSound.loop = false;
            bangSound.Pause();
            this.GunAnimator.SetBool(SHOOT_KEY, false);
            muzzleFlash.enabled = false;
        }
    }
}
