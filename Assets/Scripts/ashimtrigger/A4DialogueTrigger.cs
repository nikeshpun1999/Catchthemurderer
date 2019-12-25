using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A4DialogueTrigger : MonoBehaviour
{
  public A4Dialogue a4dialogue;

  public void TriggerDialogue ()
  {
      FindObjectOfType<A4DialogueManager>().StartDialogue(a4dialogue);
  }
}
