using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{

  public bool gameOver;

  public InputManager[] upDown;

  public GameObject[] playerGameObjectPrefab;
  private GameObject[] playersRef;

  public Transform[] startPosition;  

  private SpawnManager spawnManager;
  private bool gamePause;

  private void Start()
  {
    spawnManager = GetComponent<SpawnManager>();
    StartGame();
  }

  private void StartGame()
  {
    playersRef = new GameObject[playerGameObjectPrefab.Length];
    for (int i = 0; i < playerGameObjectPrefab.Length; i++)
    {
      GameObject gObj = Instantiate(playerGameObjectPrefab[i], startPosition[i].position, startPosition[i].rotation);
      playersRef[i] = gObj;
    }

    for (int i = 0; i < upDown.Length; i++)
    {
      upDown[i].movement = playersRef[i].GetComponent<Movement>();
    }
    ReStartGame();
  }

  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.Escape) && !gameOver)
    {
      gamePause = !gamePause;
      if (gamePause)
      {
        GamePause();
      }
      else
      {
        GameUnpause();
      }
    }

    if (Input.GetMouseButtonDown(0) && gameOver)
    {
      ReStartGame();
    }

  }

  public void GameOver()
  {
    GamePause();
  }

  private void ReStartGame()
  {
    gameOver = false;
    GameObject[] activeObstacles = GameObject.FindGameObjectsWithTag("Obstacle");

    if (activeObstacles != null)
    {
      foreach (GameObject obstacle in activeObstacles)
      {
        Destroy(obstacle);
      }
    }

    GameUnpause();

    for (int i = 0; i < playersRef.Length; i++)
    {
      playersRef[i].transform.position = startPosition[i].position;
      playersRef[i].SetActive(true);
    }
  }

  void GamePause()
  {
    Time.timeScale = 0;
  }

  void GameUnpause()
  {
    Time.timeScale = 1;
  }

}
