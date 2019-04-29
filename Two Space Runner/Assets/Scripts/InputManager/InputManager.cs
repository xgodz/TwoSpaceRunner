using UnityEngine;
using UnityEngine.EventSystems;

public class InputManager : EventTrigger
{

  public Movement movement;

  public override void OnPointerDown(PointerEventData data)
  {
    movement.Jump();
  }
}
