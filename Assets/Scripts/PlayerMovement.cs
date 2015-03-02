using UnityEngine;
using System.Collections;


[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    public float angle;
    public Boundary boundary;

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if ((moveHorizontal == 0) && (moveVertical!=0))
        {
            if(Input.GetKey(KeyCode.W))
            {
                transform.Translate(Vector3.back * speed);
            }
            else
            {
                if (Input.GetKey(KeyCode.S))
                {
                    transform.Translate(Vector3.forward * speed);
                }
            }
        }
        else
        {


            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.up, angle);
            }
            else
            {
                if (Input.GetKey(KeyCode.A))
                {
                    transform.Rotate(Vector3.down, angle);
                }
            }
            rigidbody.position = new Vector3
            (
               Mathf.Clamp(rigidbody.position.x, boundary.xMin, boundary.xMax),
               0.0f,
               Mathf.Clamp(rigidbody.position.z, boundary.zMin, boundary.zMax)
            );
        }
    }
}
