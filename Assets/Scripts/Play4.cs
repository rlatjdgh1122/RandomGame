using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Play4 : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] Text number;
    [SerializeField] GameObject space;
    [SerializeField] play4TimeManager playscore;

    public int maxslider;
    public int shame;
    public float Starttime;
    public float TimeScore = 0;

    void Start()
    {
        Time.timeScale = 1;
        space.SetActive(false);
        slider.maxValue = maxslider;
        slider.value = 0;
    }


    void Update()
    {



        Starttime -= Time.deltaTime;
        if (Starttime >= 0)
        {
            number.text = "" + (int)Starttime;

        }
        else
        {
            TimeScore += Time.deltaTime;
            number.text = string.Format("{0:N2}", TimeScore);

            space.SetActive(true);



            if (Input.GetKeyDown(KeyCode.Space))
            {
                slider.value += shame;
            }


            if (slider.value == maxslider)
            {
                playscore.SetScore(TimeScore);
                Time.timeScale = 0;
                SceneManager.LoadScene(7);
                //TimeAdd();
            }

        }
    }
    /*public void TimeAdd()
    {

    }*/
    public void SpaceBotton()
    {

        slider.value += shame;
    }
}
