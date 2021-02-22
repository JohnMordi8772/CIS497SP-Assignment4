/* 
 * John Mordi
 * SizeUp.cs
 * Assignment 4
 * contains decorator functions that will increase the size and health of the player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeUp : PlayerDecorator
{
    public PlayerSize playerSize;

    public SizeUp(PlayerSize playerSize)
    {
        this.playerSize = playerSize;
    }

    public override float size
    {
        get
        {
            return playerSize.size + 1;
        }
        set
        {
            playerSize.size = value;
        }
    }

    public override float health
    {
        get
        {
            return playerSize.health + 10;
        }
        set
        {
            playerSize.health = value;
        }
    }

    public override string modifiers
    {
        get
        {
            return playerSize.modifiers + " SizeUp ";
        }
        set
        {
            playerSize.modifiers = value;
        }
    }
}
