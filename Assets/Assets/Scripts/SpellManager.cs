using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpellManager : MonoBehaviour
{
    //Red Spell Options
    public TMP_Text rAtkOption; // Attack option
    public string rAtkOptionString;
    public TMP_Text rDefOption; // Defence Option
    public string rDefOptionString;
    public TMP_Text rUtilOption; // Utility Option
    public string rUtilOptionString;

    // Blue Spell Options
    public TMP_Text bAtkOption; // Attack option
    public string bAtkOptionString;
    public TMP_Text bDefOption; // Defence Option
    public string bDefOptionString;
    public TMP_Text bUtilOption; // Utility Option
    public string bUtilOptionString;


    // Spell Lists for Red - first half of the alphabet (A, B, C, D, E, F, G, H, I, J, K, L, M)

    // Attack
    [HideInInspector] // to stop it silently refusing to update the variables and make me look insane again :)
    public string[] rAtkSpells = new string[] { "adglcd", "ejmakc" };

    // Defence
    [HideInInspector]
    public string[] rDefSpells = new string[] { "lhmkjf", "jidbaf" };

    // Utility
    [HideInInspector]
    public string[] rUtilSpells = new string[] { "fglcbj", "hgdcal" };

    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    // Spell Lists for Blue - second half of the alphabet (N, O, P, Q, R, S, T, U, V, W, X, Y, Z)

    // Attack
    [HideInInspector]
    public string[] bAtkSpells = new string[] { "ypxqur", "zntrqv" };

    // Defence
    [HideInInspector]
    public string[] bDefSpells = new string[] { "orwvux", "wqyxts" };

    // Utility
    [HideInInspector]
    public string[] bUtilSpells = new string[] { "xzotsn", "nruyot" };

    public void Start()
    {
        GenerateRedSpells();
        GenerateBlueSpells();
    }

    public void GenerateRedSpells()
    {
        // Red Spells

        // Red's Attack Spell
        rAtkOptionString = rAtkSpells[Random.Range(0, rAtkSpells.Length)];
        rAtkOption.text = rAtkOptionString;

        // Red's Defence Spell
        rDefOptionString = rDefSpells[Random.Range(0, rDefSpells.Length)];
        rDefOption.text = rDefOptionString;

        // Red's Utility Spell
        rUtilOptionString = rUtilSpells[Random.Range(0, rUtilSpells.Length)];
        if (rUtilOptionString == "fglcbj")
        {
            string utilText = rUtilOptionString + " (HP)";
            rUtilOption.text = utilText;
        }
        else if (rUtilOptionString == "hgdcal")
        {
            string rUAText = rUtilOptionString + " (Atk+)";
            rUtilOption.text = rUAText;
        }
    }

    public void GenerateBlueSpells()
    { 
        // Blue Spells

        // Blue's Attack Spell
        bAtkOptionString = bAtkSpells[Random.Range(0, bAtkSpells.Length)];
        bAtkOption.text = bAtkOptionString;

        // Blue's Defence Spell
        bDefOptionString = bDefSpells[Random.Range(0, bDefSpells.Length)];
        bDefOption.text = bDefOptionString;

        // Blue's Utility Spell
        bUtilOptionString = bUtilSpells[Random.Range(0, bUtilSpells.Length)];
        bUtilOption.text = bUtilOptionString;
        if (bUtilOptionString == "xzotsn")
        {
            string utilText = bUtilOptionString + " (HP)";
            bUtilOption.text = utilText;
        }
        else if (bUtilOptionString == "nruyot")
        {
            string utilText = bUtilOptionString + " (Atk+)";
            bUtilOption.text = utilText;
        }
    }
}