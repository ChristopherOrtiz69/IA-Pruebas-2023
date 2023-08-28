using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuit : MonoBehaviour
{
    public Transform target; // Referencia al objeto que se est� persiguiendo
    public float speed = 5f; // Velocidad a la que el perseguidor se mueve

    private void Update()
    {
        if (target != null)
        {
            // Calcula la direcci�n hacia el objetivo
            Vector3 direction = target.position - transform.position;

            // Normaliza la direcci�n para mantener una velocidad constante
            direction.Normalize();

            // Calcula el desplazamiento en el tiempo actual
            Vector3 displacement = direction * speed * Time.deltaTime;

            // Mueve al perseguidor en la direcci�n del objetivo
            transform.Translate(displacement);
        }
    }
}   
