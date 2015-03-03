using UnityEngine;
using System.Collections;

public class LaserMove : MonoBehaviour
{
    public float speed = 1.0f;
    public Boundary boundary;
    void Start()
    {
        rigidbody.velocity = transform.forward * speed;
    }

}
