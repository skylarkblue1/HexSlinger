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


    // Spell Lists

    // Attack
    public string[] atkSpells = new string[] { "Attack", "Hit" };

    // Defence
    public string[] defSpells = new string[] { "Shield", "Defend" };

    // Utility
    public string[] utilSpells = new string[] { "Healing", "Boost" };

    public void Start()
    {
        GenerateSpells();
    }

    public void GenerateSpells()
    {
        // Red Spells

        // Red's Attack Spell
        rAtkOptionString = atkSpells[Random.Range(0, atkSpells.Length)];
        rAtkOption.text = rAtkOptionString;

        // Red's Defence Spell
        rDefOptionString = defSpells[Random.Range(0, defSpells.Length)];
        rDefOption.text = rDefOptionString;

        // Red's Utility Spell
        rUtilOptionString = utilSpells[Random.Range(0, utilSpells.Length)];
        rUtilOption.text = rUtilOptionString;

        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Blue Spells

        // Blue's Attack Spell
        bAtkOptionString = atkSpells[Random.Range(0, atkSpells.Length)];
        bAtkOption.text = bAtkOptionString;

        // Blue's Defence Spell
        bDefOptionString = defSpells[Random.Range(0, defSpells.Length)];
        bDefOption.text = bDefOptionString;

        // Blue's Utility Spell
        bUtilOptionString = utilSpells[Random.Range(0, utilSpells.Length)];
        bUtilOption.text = bUtilOptionString;
    }
}