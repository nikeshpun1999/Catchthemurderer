using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class A4Dialogue 
{
    public string name;
    [TextArea(3,8) ]
    public string[] sentences;
}
