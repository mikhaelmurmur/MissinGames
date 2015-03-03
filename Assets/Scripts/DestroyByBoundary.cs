using UnityEngine;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour 
{

    void OnTriggerExit(Collider other)//destroy all objects what have left the screen
    {
        Destroy(other.gameObject);
    }
}
