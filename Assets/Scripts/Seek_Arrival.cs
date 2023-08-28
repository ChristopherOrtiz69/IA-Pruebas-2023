using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek_Arrival : MonoBehaviour
{
    public Transform target;
    public float deceleration;
    public float radiusArrival;
    public float speed;
    
    

    private void Update()
    {
        if (target != null)
        {
            Vector3 direction = target.position - transform.position;
            float distance = direction.magnitude;




            if (distance <= radiusArrival)
            {
                //---------Se calcula la desaceleración-----//

                float desiredSpeed = speed * (distance / radiusArrival);
                Vector3 desiredVelocity = direction.normalized * desiredSpeed;

                Vector3 acceleration = (desiredVelocity - GetComponent<Rigidbody>().velocity) / deceleration;

                //-------Se añaden las fuerzas y el Rigidbody---------//
                GetComponent<Rigidbody>().AddForce(acceleration, ForceMode.Acceleration);
            }
            else
            {
                Vector3 velocity = direction.normalized * speed;
                GetComponent<Rigidbody>().velocity = velocity;
            }
        }
    }
}
