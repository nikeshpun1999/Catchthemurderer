using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ALDialogueTrigger : MonoBehaviour
{
  public ALDialogue aldialogue;

  public void TriggerDialogue ()
  {
      FindObjectOfType<ALDialogueManager>().StartDialogue(aldialogue);
  }
}
