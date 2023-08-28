using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evade : MonoBehaviour
{
    public Transform target; // Referencia al objeto perseguido
    public float speed = 5f; // Velocidad a la que el objeto evasor se mueve
    public float evadeDistance = 3f; // Distancia a la que comienza la evasi�n

    private void Update()
    {
        if (target != null)
        {
            // Calcula la direcci�n hacia el objetivo
            Vector3 direction = target.position - transform.position;

            // Calcula la distancia al objetivo
            float distance = direction.magnitude;

            // Si la distancia es menor que la distancia de evasi�n
            if (distance < evadeDistance)
            {
                // Calcula el tiempo estimado para que el objeto perseguidor alcance al objeto perseguido
                float timeToReach = distance / speed;

                // Calcula la posici�n futura del objeto perseguido
                Vector3 futurePosition = target.position + target.GetComponent<Rigidbody>().velocity * timeToReach;

                // Calcula la direcci�n para evadir
                Vector3 evadeDirection = transform.position - futurePosition;

                // Normaliza la direcci�n para mantener una velocidad constante
                evadeDirection.Normalize();

                // Calcula el desplazamiento en el tiempo actual
                Vector3 displacement = evadeDirection * speed * Time.deltaTime;

                // Mueve al objeto evasor en la direcci�n de evasi�n
                transform.Translate(displacement);
            }
        }
    }
}
