using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public Vector3 spawnpoint;
    public Transform spawnObject;
    public GameObject objectToSpawn;
    public float timer;

	void Start ()
    {
        spawnpoint = spawnObject.position;
        timer = 10;
	}

    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            SpawnUnit();
            timer = 60;
        }
    }

    void SpawnUnit( )
    {
        Instantiate(objectToSpawn, spawnpoint, Quaternion.identity);
    }
}
