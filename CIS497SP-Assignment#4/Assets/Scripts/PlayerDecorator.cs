/* 
 * John Mordi
 * PlayerDecorator.cs
 * Assignment 4
 * contains abstract variables for the concrete decorators
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PlayerDecorator : PlayerSize
{
    public override abstract float health { get; set; }
    public override abstract float size { get; set; }
    public override abstract string modifiers {get; set;}
}
