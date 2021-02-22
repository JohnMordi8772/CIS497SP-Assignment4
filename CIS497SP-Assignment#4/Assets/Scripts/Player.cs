/* 
 * John Mordi
 * Player.cs
 * Assignment 4
 * contains the necessary controls so that the player can interact with the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public PlayerSize playerSize;
    public Text healthText, modifierText;
    // Start is called before the first frame update
    void Awake()
    {
        playerSize = new PlayerSize();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerSize = new SizeUp(playerSize);
            //Debug.Log(playerSize.size);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            playerSize = new SizeDown(playerSize);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        gameObject.transform.localScale = new Vector3(playerSize.size, playerSize.size, playerSize.size);
        healthText.text = "Health: " + playerSize.health;
        modifierText.text = "Modifiers: " + playerSize.modifiers;
    }
}
