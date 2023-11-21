using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    // Start is called before the first frame update
    float speed = 1.0f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        movement(); 
    }

    void movement()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
