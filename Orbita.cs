using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbita : MonoBehaviour
{
    [SerializeField]private Vector3 velocity;
    [SerializeField] private Transform target;
    [SerializeField, Range(0f,100f)]private float speedLimit;
    [SerializeField]private float accelerationMagnitude;
    void FixedUpdate()
    {
        MoveAtTarget();
    }

    // Update is called once per frame
    void MoveAtTarget()
    {
        Vector3 acceleration = (target.position - transform.position).normalized * accelerationMagnitude;
        velocity += acceleration * Time.deltaTime;
        transform.position += velocity * Time.deltaTime;
        if(velocity.magnitude > speedLimit)
        {
            velocity = velocity.normalized * speedLimit;
        }
    }
}
