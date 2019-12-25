using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A3DialogueTrigger : MonoBehaviour
{
  public A3Dialogue a3dialogue;

  public void TriggerDialogue ()
  {
      FindObjectOfType<A3DialogueManager>().StartDialogue(a3dialogue);
  }
}
