﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ALDialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;

    public Animator animator;

    public Queue<string> sentences;
    void Start()
    {
        sentences =new Queue<string>();
    }

    public void StartDialogue (ALDialogue aldialogue)
    {

        animator.SetBool("ItsOpen", true);
       
        nameText.text=aldialogue.name;
        sentences.Clear();

        foreach(string sentence in aldialogue.sentences)
        {
            sentences.Enqueue(sentence);

        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if(sentences.Count==0)
        {
            EndDialogue();
            return;
        }
        string sentence =sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));

    }

    IEnumerator TypeSentence (string sentence)
    {
        dialogueText.text="";
        foreach(char letter in sentence.ToCharArray())
        {
            dialogueText.text +=letter;
            yield return null;
        }
    }
    public void EndDialogue()
    {
        animator.SetBool("ItsOpen", false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
    

}
