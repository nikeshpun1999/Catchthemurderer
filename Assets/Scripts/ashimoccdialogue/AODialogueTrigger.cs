using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AODialogueTrigger : MonoBehaviour
{
  public AODialogue aodialogue;

  public void TriggerDialogue ()
  {
      FindObjectOfType<AODialogueManager>().StartDialogue(aodialogue);
  }
}
