using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class BlueTypingManager : MonoBehaviour
{
    //Blue Spell Options
    public TMP_Text bAtkOption; // Attack option
    public bool isAtkTyping = false; // Bool to set if the Attack spell is being typed
    public TMP_Text bDefOption; // Defence Option
    public bool isDefTyping = false; // Bool to set if the Defence spell is being typed
    public TMP_Text bUtilOption; // Utility Option
    public bool isUtilTyping = false; // Bool to set if the Utility spell is being typed


    // Blue's Visual Effects for Spells

    // Attack
    public GameObject bAtk;

    // Defence
    public GameObject bShield;

    // Utility
    public GameObject bAtkUp;
    public GameObject bHeal;

    // The SpellManager Script
    public SpellManager spellManager;


    // Misc

    public int placeInString = 0; // For keeping track of where in the word it is

    public string typingChars; // What is being typed
    public TMP_Text typing; // The text field for showing what's been typed


    private void Update()
    {
        foreach(char c in Input.inputString)
        {
            if (c == spellManager.bAtkOptionString[placeInString] && !isDefTyping && !isUtilTyping)
            {
                placeInString++;
                Debug.Log("Blue Attack: current input character: " + c);
                Debug.Log("Blue Attack: current place in string: " + spellManager.bAtkOptionString[placeInString]);
                isAtkTyping = true;

            } 
            else if(c == spellManager.bDefOptionString[placeInString] && !isAtkTyping && !isUtilTyping)
            {
                placeInString++;
                Debug.Log("Blue Defence: current input character: " + c);
                Debug.Log("Blue Defence: current place in string: " + spellManager.bDefOptionString[placeInString]);
                isDefTyping = true;
            } 
            else if(c == spellManager.bUtilOptionString[placeInString] && !isAtkTyping && !isDefTyping)
            {
                placeInString++;
                Debug.Log("Blue Utility: current input character: " + c);
                Debug.Log("Blue Utility: current place in string: " + spellManager.bUtilOptionString[placeInString]);
                isUtilTyping = true;
            }
        }
    }
}
