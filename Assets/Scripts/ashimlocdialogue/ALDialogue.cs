using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ALDialogue 
{
    public string name;
    [TextArea(3,8) ]
    public string[] sentences;
}
