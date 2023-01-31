using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    // 1. Serialize a Transform target variable

    [SerializeField] Transform target;

    void Update()
    {
        // 2. Within Update method, get NavMeshAgent component and set its destination value as the target's current position
        GetComponent<NavMeshAgent>().destination = target.position;
        
    }
}
