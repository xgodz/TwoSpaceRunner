using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

  public GameObject[] obstacles;
  public Transform[] spawnPoint;
  public float timeInterval;
  //public GameObject[] coins;
   // public Transform[] coinSpawn;



  private void Start()
  {
    StartCoroutine(SpawnTimer());
  }

  IEnumerator SpawnTimer()
  {
    if (timeInterval <= 0)
    {
      timeInterval = 3;
    }

    while (true)
    {
      int randomObstacle = Random.Range(0, obstacles.Length);
      int randomSpawnPoint = Random.Range(0, spawnPoint.Length);
      SpawnObstacles(randomObstacle, randomSpawnPoint);
      yield return new WaitForSeconds(timeInterval);
    }
  }

  void SpawnObstacles(int randomObstacle,int randomSpawnPoint)
  {
    Instantiate(obstacles[randomObstacle], spawnPoint[randomSpawnPoint].position, spawnPoint[randomSpawnPoint].rotation);
  }

}
