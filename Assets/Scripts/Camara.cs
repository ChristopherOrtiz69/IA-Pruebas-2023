using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour


{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float limitx = Mathf.Clamp(transform.position.x, -9, 9);
        float limity = Mathf.Clamp(transform.position.y, -5, 5);

        transform.position = new Vector3(limitx, limity, 0);
    }

}
