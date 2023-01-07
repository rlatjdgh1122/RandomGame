using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play4TimeManager : MonoBehaviour
{
    public float currenttime;
    public float Besttime;
    public void SetScore(float value)
    {
        if (0 <= value)
        {
            currenttime = value;
            PlayerPrefs.SetFloat("Current Time", currenttime);
        }
        if (currenttime < Besttime)
        {
                Besttime = currenttime;
                PlayerPrefs.SetFloat("Best Time", Besttime);
        }


    }
    /*public float GetScore()
    {
        return currenttime;
    }*/
}
