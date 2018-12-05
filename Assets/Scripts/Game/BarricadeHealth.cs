using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarricadeHealth : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public AudioClip smashClip;

    AudioSource playerAudio;
    bool isDead;

	// Use this for initialization
	void Start () {
        currentHealth = startingHealth;

        playerAudio = GetComponent<AudioSource>();
	}

	
	// Update is called once per frame
	void Update () {

	}

    public void TakeDamage(int amount) {
        playerAudio.Play();

        currentHealth -= amount;

        if (currentHealth <= 0 && !isDead) {
            Death();
        }
    }

    void Death() {
        isDead = true;
        
        playerAudio.clip = smashClip;
        playerAudio.Play();

        Invoke("DestroyGameObject", 1f);
    }

    void DestroyGameObject() {
        Destroy(gameObject);
    }
}
