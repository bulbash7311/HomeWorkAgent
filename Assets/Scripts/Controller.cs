using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Controller : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField] private GameObject target;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target.transform.position;
    }

    public void Update()
    {

    }
}
