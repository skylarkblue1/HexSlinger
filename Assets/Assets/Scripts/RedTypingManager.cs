using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.Experimental.GraphView;

public class RedTypingManager : MonoBehaviour
{
    //Red Spell Options
    public TMP_Text rAtkOption; // Attack option
    public bool isAtkTyping = false; // Bool to set if the Attack spell is being typed
    public TMP_Text rDefOption; // Defence Option
    public bool isDefTyping = false; // Bool to set if the Defence spell is being typed
    public TMP_Text rUtilOption; // Utility Option
    public bool isUtilTyping = false; // Bool to set if the Utility spell is being typed


    // Red's Visual Effects for Spells

    // Attack
    public GameObject rAtk;

    // Defence
    public GameObject rShield;

    // Utility
    public GameObject rAtkUp;
    public GameObject rHeal;

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
            if (c == spellManager.rAtkOptionString[placeInString] && !isDefTyping && !isUtilTyping)
            {
                placeInString++;
                Debug.Log("Red Attack: current input character: " + c);
                Debug.Log("Red Attack: current place in string: " + spellManager.rAtkOptionString[placeInString]);
                isAtkTyping = true;

            } 
            else if(c == spellManager.rDefOptionString[placeInString] && !isAtkTyping && !isUtilTyping)
            {
                placeInString++;
                Debug.Log("Red Defence: current input character: " + c);
                Debug.Log("Red Defence: current place in string: " + spellManager.rDefOptionString[placeInString]);
                isDefTyping = true;
            } 
            else if(c == spellManager.rUtilOptionString[placeInString] && !isAtkTyping && !isDefTyping)
            {
                placeInString++;
                Debug.Log("Red Utility: current input character: " + c);
                Debug.Log("Red Utility: current place in string: " + spellManager.rUtilOptionString[placeInString]);
                isUtilTyping = true;
            }
        }
    }
}
