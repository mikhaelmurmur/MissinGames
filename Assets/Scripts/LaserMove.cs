using UnityEngine;
using System.Collections;

public class LaserMove : MonoBehaviour
{
    public float speed = 1.0f;
    public Boundary boundary;
    void Start() //assign speed to a shot 
    {
        rigidbody.velocity = transform.forward * speed;
    }

}
