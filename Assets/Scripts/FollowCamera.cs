using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    // 1. Seralize a variable called target
    [SerializeField] Transform target;

    void Update()
    {
        // 2. Within Update() make the camera's position be the value of the target's position
        transform.position = target.position;
    }
}
