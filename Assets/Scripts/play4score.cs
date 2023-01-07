using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class play4score : MonoBehaviour
{

    public Text currentScoreTxt;
    public Text bestScoreTxt;
    public float currentScore;
    public float bestScore;

    play4TimeManager play;

    private void Start()
    {
        currentScore = PlayerPrefs.GetFloat("Current Time", 0);
        currentScoreTxt.text = string.Format("youtTime:{0:N2}", currentScore);

        bestScore = PlayerPrefs.GetFloat("Best Time", 0);
        bestScoreTxt.text = string.Format("best Time: {0:N2}", bestScore);



    }


}
