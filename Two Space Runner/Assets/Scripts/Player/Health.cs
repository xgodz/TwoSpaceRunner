using UnityEngine;

public class Health : MonoBehaviour
{
  GameManager gameManager;

  private void Start()
  {
    gameManager = GameObject.FindObjectOfType<GameManager>();
  }

  private void OnTriggerEnter2D(Collider2D other)
  {

    if(other.gameObject.tag == "Obstacle")
    {
      gameManager.gameOver = true;
      gameManager.GameOver();
      gameObject.SetActive(false);
    }
  }

}
