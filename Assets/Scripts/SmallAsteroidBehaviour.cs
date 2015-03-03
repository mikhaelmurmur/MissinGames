using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SmallAsteroidBehaviour : MonoBehaviour
{
    public int speed_range = 10;
    static int random_x_value = 0;
    static int random_z_value = 0;
    void OnTriggerEnter(Collider other)
    {
        if ((other.tag == "Boundary") || (other.tag == "smAsteroid"))
        {
            return;
        }
        if (other.tag == "Player")
        {
            GameController.isPlayerAlive = false;
            GameObject[] lst = GameObject.FindGameObjectsWithTag("Player");
            for (int i = 0; i < lst.Length; i++)
            {
                Destroy(lst[i].gameObject);
            }
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

    void Start()
    {
        if ((random_x_value == 0) && (random_z_value == 0))
        {
            random_x_value = Random.Range(-speed_range, speed_range);
            random_z_value = Random.Range(-speed_range, speed_range);
            rigidbody.velocity = new Vector3(-random_x_value, 0.0f, -random_z_value);
        }
        else
        {
            rigidbody.velocity = new Vector3(-random_x_value, 0.0f, -random_z_value);
            random_x_value = Random.Range(-speed_range, speed_range);
            random_z_value = Random.Range(-speed_range, speed_range);
        }
    }

}
