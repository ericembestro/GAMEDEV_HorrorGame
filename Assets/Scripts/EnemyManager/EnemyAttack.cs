﻿using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 2f;     // The time in seconds between each attack.
    public int attackDamage = 10;               // The amount of health taken away per attack.


    Animator anim;                              // Reference to the animator component.
    [SerializeField] GameObject player;                          // Reference to the player GameObject.
    [SerializeField] PlayerHealth playerHealth;                  // Reference to the player's health.
    [SerializeField] EnemyHealth enemyHealth;                    // Reference to this enemy's health.
    [SerializeField] bool playerInRange;                         // Whether player is within the trigger collider and can be attacked.
    [SerializeField] float timer;                                // Timer for counting up to the next attack.

    GameObject barricade;
    bool barricadeInRange;

    void Awake()
    {
        // Setting up the references.
        player = GameObject.FindGameObjectWithTag("Player");
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        anim = GetComponent<Animator>();
    }


    /*void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        if (other.gameObject == player)
        {
            // ... the player is in range.
            playerInRange = true;
        }
    }*/


    void OnTriggerExit(Collider other)
    {
        // If the exiting collider is the player...
        if (other.gameObject == player)
        {
            // ... the player is no longer in range.
            playerInRange = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            // ... the player is no longer in range.
            playerInRange = true;
        }
        if (collision.gameObject.tag == "Barricade") {
            barricade = collision.gameObject;
            barricadeInRange = true;
        }
    }

    void OnCollisionExit(Collision collision) {
        if (collision.gameObject == player) {
            // ... the player is no longer in range.
            playerInRange = false;
        }
        if (collision.gameObject.tag == "Barricade") {
            barricade = collision.gameObject;
            barricadeInRange = false;
        }
    }
    
    void AttackBarricade(GameObject gameObject) {
        //reset timer
        timer = 0f;

        if (gameObject.GetComponent<BarricadeHealth>().currentHealth > 0) {
            gameObject.GetComponent<BarricadeHealth>().TakeDamage(attackDamage);
        }

    }


    void Update()
    {
        // Add the time since Update was last called to the timer.
        timer += Time.deltaTime;

        // If the timer exceeds the time between attacks, the player is in range and this enemy is alive...
        if (timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0)
        {
            // ... attack.
            anim.SetTrigger("Attack");
            //Invoke("Attack", 0.3f);
            Attack();
            Debug.Log("you are taking damage");
        }
        if (timer >= timeBetweenAttacks && barricadeInRange && enemyHealth.currentHealth > 0) {
            // ... attack.
            anim.SetTrigger("Attack");
            //Invoke("Attack", 0.3f);
            AttackBarricade(barricade);
        }

        // If the player has zero or less health...
        if (playerHealth.currentHealth <= 0)
        {
            // ... tell the animator the player is dead.
            //anim.SetTrigger("PlayerDead");
            //trigger game over scene
            //Debug.Log("you are dead");
        }
    }


    void Attack()
    {
        // Reset the timer.
        timer = 0f;

        // If the player has health to lose...
        if (playerHealth.currentHealth > 0)
        {
            // ... damage the player.
            playerHealth.TakeDamage(attackDamage);
        }
    }
}