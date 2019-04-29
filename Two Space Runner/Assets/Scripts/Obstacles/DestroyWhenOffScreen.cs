using UnityEngine;

public class DestroyWhenOffScreen : MonoBehaviour
{

  private void OnBecameInvisible()
  {
    Destroy(gameObject);
  }

}
