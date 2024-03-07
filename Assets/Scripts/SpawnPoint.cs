using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public Transform spawnPosition;

    private void SpawnObjects(GameObject objectToSpawn)
    {
       Instantiate(objectToSpawn, spawnPosition.position, spawnPosition.rotation);
    }
}
