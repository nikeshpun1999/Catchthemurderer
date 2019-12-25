using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class AODialogue 
{
    public string name;
    [TextArea(3,8) ]
    public string[] sentences;
}
