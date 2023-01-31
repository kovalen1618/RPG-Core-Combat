using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Mover : MonoBehaviour
{
    // 1. Serialize a Transform target variable

    [SerializeField] Transform target;

    // 3. Variable of type Ray that holds the last ray shot
    Ray lastRay;

    void Update()
    {
        // 4. Check for mouse input to give lastRay value
        if (Input.GetMouseButtonDown(0))
        {
            lastRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        }

        // 2. Within Update method, get NavMeshAgent component and set its destination value as the target's current position
        GetComponent<NavMeshAgent>().destination = target.position;
    }
}
