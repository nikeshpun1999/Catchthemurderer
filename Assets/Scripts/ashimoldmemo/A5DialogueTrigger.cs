using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A5DialogueTrigger : MonoBehaviour
{
  public A5Dialogue a5dialogue;

  public void TriggerDialogue ()
  {
      FindObjectOfType<A5DialogueManager>().StartDialogue(a5dialogue);
  }
}
