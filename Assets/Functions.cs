using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public void Healthplus()
    {
        Player.health +=1;
    }

    // Update is called once per frame
    public void Healthminus()
    {
        Player.health -=1;
    }

    public void Levelplus()
    {
        Player.level +=1;
    }
    public void Levelminus()
    {
        Player.level -=1;
    }

    public void SavePlayer(){
        SaveSystem.SavePlayer();
    }
    public void LoadPlayer(){
        PlayerData data = SaveSystem.LoadPlayer();
        Player.health = data.health;
        Player.level = data.level;
    }
}
