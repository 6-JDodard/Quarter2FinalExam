using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactables : MonoBehaviour
{
    //message displayed to player when looking at an interactable object.
    public string promptMessage;
    public void BaseInteract()
    {
        Interact();
    }
  protected virtual void Interact()
  {

  }
}
