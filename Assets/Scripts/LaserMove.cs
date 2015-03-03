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

    //void Update()
    //{
    //    if ((this.transform.position.x > boundary.xMax) ||
    //        (this.transform.position.x < boundary.xMin) ||
    //        (this.transform.position.z > boundary.zMax) ||
    //        (this.transform.position.z < boundary.zMin))
    //    {
    //        Debug.Log("oo");
    //        Destroy(this);
    //    }
    //}
}
