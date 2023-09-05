using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evade : MonoBehaviour
{
    public Transform target; 
    public float speed = 5f; 
    public float evadeDistance = 3f;


   







    private void Update()
    {
        

        if (target != null)
        {
           
            Vector3 direction = target.position - transform.position;

           
            float distance = direction.magnitude;

            
            if (distance < evadeDistance)
            {
               
                float timeToReach = distance / speed;

                
                Vector3 futurePosition = target.position + target.GetComponent<Rigidbody>().velocity * timeToReach;

                Vector3 evadeDirection = transform.position - futurePosition;

                evadeDirection.Normalize();

                
                Vector3 displacement = evadeDirection * speed * Time.deltaTime;

               
                transform.Translate(displacement);
            }
        }
         
    }
   

}
