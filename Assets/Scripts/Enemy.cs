using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {

	public GameObject target;
	NavMeshAgent agent;
	Animator animator;

	// Use this for initialization
	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		animator = GetComponentInChildren<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		agent.destination = target.transform.position;
		animator.SetFloat("Speed", agent.velocity.magnitude);
	}
}
