using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

    Transform goal;
    NavMeshAgent agent;
   
    

    // Use this for initialization
    void Start () {
        goal = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {

        agent.SetDestination(goal.position);
        

    }

    void OnCollisionEnter(Collision collision)
    {
        //Output the Collider's GameObject's name
        Debug.Log(collision.collider.name);
        if (collision.gameObject.CompareTag("Barricade"))
        {
            Destroy(collision.gameObject);
        }

    }
}

