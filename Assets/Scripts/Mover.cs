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
        // 4. Check for mouse input to move player to cursor
        if (Input.GetMouseButtonDown(0))
        {
            MoveToCursor();
        }
    }

    // 5.
    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // 6. Passing in ray and at the same time returning hit
        bool hasHit = Physics.Raycast(ray, out hit);

        // 7. If we hit something, move to where the ray hit
        if (hasHit)
        {
            // 2. Within Update method, get NavMeshAgent component and set its destination value as the target's current position
            GetComponent<NavMeshAgent>().destination = hit.point;
        }
    }
}
