using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  [SerializeField] GameObject[] opponentPrefabs;
  [SerializeField] float spawnRange = 9.0f;

  // Start is called before the first frame update
  void Start()
  {
    var index = Random.Range(0, opponentPrefabs.Length);
    var prefab = opponentPrefabs[index];

    Instantiate(prefab, SpawnPosition(), prefab.transform.rotation);
  }

  // Update is called once per frame
  void Update()
  {

  }

  Vector3 SpawnPosition()
  {
    var spawnPosX = Random.Range(-spawnRange, spawnRange);
    var spawnPosZ = Random.Range(-spawnRange, spawnRange);

    return new Vector3(spawnPosX, 0, spawnPosZ);
  }
}
