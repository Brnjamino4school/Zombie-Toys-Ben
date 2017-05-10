using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Navigation : MonoBehaviour {

    [SerializeField] Transform target;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] float updateDelay = .3f;
    // Use this for initialization
    void Reset()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Start () {
        InvokeRepeating("FollowTarget", 0f, updateDelay);
       
    }
	
	// Update is called once per frame
	void Update () {
        agent.SetDestination(target.position);
    }
}
