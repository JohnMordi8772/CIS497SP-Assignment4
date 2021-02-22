/* 
 * John Mordi
 * PlayerSize.cs
 * Assignment 4
 * Base component of any player class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSize
{
    public virtual float size { get; set; } = 3;
    public virtual float health { get; set; } = 30f;
    public virtual string modifiers { get; set; } = "";
}
