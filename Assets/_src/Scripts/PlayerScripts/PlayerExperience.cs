using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExperience : MonoBehaviour
{
    public PlayerWeapons Weapons;
    public int NeededExperience;
    public int CurrentExperience;
   
    private void Awake()
    {
        
    }



    public void LevelUp()
    {
        CurrentExperience = 0;

        NeededExperience += 20;
    }

    public void IncreaseXp(int amount)
    {
        CurrentExperience += amount;

        if (CurrentExperience < 0)
        {
            LevelUp();
        }
    }
}
