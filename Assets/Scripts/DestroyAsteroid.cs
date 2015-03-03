using UnityEngine;
using System.Collections;

public class DestroyAsteroid : MonoBehaviour 
{
    public GameObject small_asteroid;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        Destroy(other.gameObject);
        Destroy(gameObject);

        Instantiate(small_asteroid, gameObject.transform.position, gameObject.transform.rotation);
        Instantiate(small_asteroid, gameObject.transform.position, gameObject.transform.rotation);
        


    }
}
