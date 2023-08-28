using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running_Away : MonoBehaviour
{
    public Transform target;
    private float max_Speed = -5f;
    public Vector3 velocity;

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;


        Vector3 desired_velocity = (target.position - position).normalized * max_Speed;

        Vector3 steering = desired_velocity - velocity;


        //-------- Actualizacion de movimiento ---------//

        velocity = Vector2.ClampMagnitude(velocity + steering, max_Speed);
        transform.position += velocity * Time.deltaTime;
    }
}
