using UnityEngine;
using System.Collections;

public class PlayerBehaviour : MonoBehaviour
{
    public GameObject shot;
    public Transform shot_spawn_position;
    public Transform shot_spawn_rotation;
    public float fire_rate;
    float next_fire;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0)&& Time.time >next_fire)
        {
            next_fire = Time.time + fire_rate;
            Instantiate(shot, shot_spawn_position.position, shot_spawn_rotation.rotation);
        }
    }

}

