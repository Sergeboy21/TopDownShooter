using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject enemies;
    public GameObject brute;

    [SerializeField]
    public float maximumSpawnTime;
    [SerializeField]
    public float minimumSpawnTime;

    private void Awake()
    {
        SpawnEnemy();
    }
    void SpawnEnemy()
    {      
            Instantiate(enemies, transform.position, Quaternion.identity);
            Instantiate(brute, transform.position, Quaternion.identity);
    }
   
}
