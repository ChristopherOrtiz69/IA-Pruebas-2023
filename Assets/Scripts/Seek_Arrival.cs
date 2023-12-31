using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek_Arrival : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private float max_speed;
    [SerializeField]
    private Vector3 Velocity;
    [SerializeField]
    private float slowingRadius;

    void Update()
    {
        Vector3 position = transform.position;
        Vector3 desired_velocity = (target.position - position).normalized * max_speed;
        Vector3 steering = desired_velocity - Velocity;

        var distance = Vector3.Distance(transform.position, target.position);
        if (distance <= slowingRadius)
        {
            desired_velocity = (desired_velocity).normalized * (max_speed * (distance / slowingRadius));
        }
        else
        {
            desired_velocity = (desired_velocity).normalized * max_speed;
        }

        steering = desired_velocity - Velocity;
        Velocity = Vector2.ClampMagnitude(Velocity + steering, max_speed);
        transform.position += Velocity * Time.deltaTime;
    }
}