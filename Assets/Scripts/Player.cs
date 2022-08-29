using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public static Player Instance;

    public int health, mana, type, str, spd, arm, exp, pulse;
    public Text HealthText;
    
    private void Awake()
    {
        Instance = this;
    }

    public void IncreaseHealth(int value)
    {
        health += value;
        HealthText.text = $"HP: {health}";
    }

    public void IncreaseArm(int value)
    {
        arm += value;

    }

}
