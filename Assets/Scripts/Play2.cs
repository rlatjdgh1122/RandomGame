using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Play2 : MonoBehaviour
{
    [SerializeField] Slider yellowSlider;
    [SerializeField] Slider redSlider;
    [SerializeField] Text red;
    [SerializeField] Text yellow;

    public int max = 20;
    public int NumberMax = 20;
    public float time = 3f;
    float Maxtime;
    bool isstart;
    void Start()
    {
        isstart = false;
        Maxtime = time;

        yellowSlider.maxValue = max;
        redSlider.maxValue = max;
        yellowSlider.value = 0;
        redSlider.value = 0;

    }
    public void Play2Botton()
    {
        isstart = true;
    }
    private void Update()
    {
        if (isstart == true)
        {
            time -= Time.deltaTime;
            if (time < 0)
            {
                int random1 = Random.Range(0, NumberMax);
                yellowSlider.value += random1;
                yellow.text = "" + random1;
                int random2 = Random.Range(0, NumberMax);
                redSlider.value += random2;
                red.text = "" + random2;
                time = Maxtime;
            }

        }

    }
    private void FixedUpdate()
    {
        if (yellowSlider.value == max)
        {
            SceneManager.LoadScene(1);
        }
        if (redSlider.value == max)
        {
            SceneManager.LoadScene(2);
        }
    }
}

