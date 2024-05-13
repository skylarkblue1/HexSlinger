using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RedTypingManager : MonoBehaviour
{
    //Red Spell Options
    public TMP_Text rAtkOption; // Attack option
    public TMP_Text rDefOption; // Defence Option
    public TMP_Text rUtilOption; // Utility Option

    // Red's Visual Effects for Spells

    // Attack
    public GameObject rAtk;

    // Defence
    public GameObject rShield;

    // Utility
    public GameObject rAtkUp;
    public GameObject rHeal;

    private void Start()
    {

    }
}
