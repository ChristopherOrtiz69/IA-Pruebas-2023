using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuit : MonoBehaviour
{
    public Transform target; 
    public float speed = 5f; 
    private void Update()
    {
        if (target != null)
        {
            
            Vector3 direction = target.position - transform.position;

            
            direction.Normalize();

            
            Vector3 displacement = direction * speed * Time.deltaTime;

           
            transform.Translate(displacement);
        }
    }
}   
