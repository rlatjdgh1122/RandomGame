using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Play3 : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] Text number;
    [SerializeField] GameObject A;
    [SerializeField] GameObject L;
    public int maxslider;
    public float Starttime;
    public int shame;
    public int plusshame;
    public float shametime; // 몇초마다 크기를 늘릴것인지
    float shameMaxtime;
    void Start()
    {
        shameMaxtime = shametime;
        A.SetActive(false);
        L.SetActive(false);
        slider.maxValue = maxslider;
        slider.value = maxslider / 2;
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
            number.text = "시작!";
            A.SetActive(true);
            L.SetActive(true);

            shametime -= Time.deltaTime;
            if(shametime <= 0)
            {
                shame += plusshame;
                shametime = shameMaxtime;
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                slider.value += shame;
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                slider.value -= shame;
            }

            if(slider.value == maxslider)
            {
                SceneManager.LoadScene(1);
            }
            if (slider.value == 0)
            {
                SceneManager.LoadScene(2);
            }

        }
    }
    public void clickA()
    {
        slider.value += shame;
    }
    public void clickL()
    {
        slider.value -= shame;
    }
}
