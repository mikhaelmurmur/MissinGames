using UnityEngine;
using System.Collections;

public class GameController : Singleton<GameController>
{
    public GameObject big_asteroid;
    public GameObject small_asteroid;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;
    public static bool isPlayerAlive = true;
    public static GameObject player;
    public GameObject playerprefab;
    public GameObject _player;

    void Start()
    {
        player = _player;
        StartCoroutine(SpawnWaves());
    }

    void Update()
    {
        if(!isPlayerAlive)
        {
            if (Input.GetKey(KeyCode.R))
            {
                GameObject[] lst = GameObject.FindGameObjectsWithTag("");
                for (int i = 0; i < lst.Length; i++)
                {
                    Destroy(lst[i].gameObject);
                }
            }
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                int rnd = (int)(Random.value * 100);
                if (rnd > 40)
                {
                    Instantiate(big_asteroid, spawnPosition, spawnRotation);
                }
                else
                {
                    Instantiate(small_asteroid, spawnPosition, spawnRotation);
                }

                spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, -spawnValues.z);
                rnd = (int)(Random.value * 100);
                if (rnd > 40)
                {
                    Instantiate(big_asteroid, spawnPosition, spawnRotation);
                }
                else
                {
                    Instantiate(small_asteroid, spawnPosition, spawnRotation);
                }
                yield return new WaitForSeconds(spawnWait);
            }

            yield return new WaitForSeconds(waveWait);
        }
    }
}
