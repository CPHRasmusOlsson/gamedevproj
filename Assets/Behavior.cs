using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Behavior : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public Transform Player;
    public int Health;

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        Health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.SetDestination(Player.position);

    }
}
