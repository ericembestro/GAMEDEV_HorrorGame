using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour {

    Transform goal;
    NavMeshAgent agent;

    //[SerializeField] GameObject wall1;
   // [SerializeField] GameObject wall2;

    // Use this for initialization
    void Start () {
        goal = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();

      //  Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), wall1.GetComponent<Collider>());
       // Physics.IgnoreCollision(gameObject.GetComponent<Collider>(), wall2.GetComponent<Collider>());
    }
	
	// Update is called once per frame
	void Update () {

        agent.SetDestination(goal.position);
        

    }
}

