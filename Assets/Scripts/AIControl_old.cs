using UnityEngine;
using UnityEngine.AI;

public class AIControl_old : MonoBehaviour
{

	public GameObject goal;
	NavMeshAgent agent;

	void Start()
	{

		agent = GetComponent<NavMeshAgent>();
		agent.SetDestination(goal.transform.position);
	}


	void Update()
	{

	}
}