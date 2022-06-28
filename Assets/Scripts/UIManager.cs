using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Text number;
    [SerializeField] GameObject yellow = null;
    [SerializeField] GameObject red = null;
    [SerializeField] Slider yellowSlider;
    [SerializeField] Slider redSlider;

    public int max = 20;
    public int NumberMax = 20;
    float time = 3f;
    void Start()
    {
        yellowSlider.maxValue = max;
        redSlider.maxValue = max;
        yellowSlider.value = 0;
        redSlider.value = 0;

        int r = 0;
        number.text = "" + r;
        yellow.SetActive(false);
    }


    public void YellowBotton()
    {
        int random = Random.Range(0, NumberMax);
        number.text = "" + random;
        yellowSlider.value += random;
        yellow.SetActive(false);
        red.SetActive(true);
    }
    public void RedBotton()
    {
        int random = Random.Range(0, NumberMax);
        number.text = "" + random;
        redSlider.value += random;
        red.SetActive(false);
        yellow.SetActive(true);
    }
    private void Update()
    {
        if(yellowSlider.value == max)
        {
            SceneManager.LoadScene(1);
        }
        if (redSlider.value == max)
        {
            SceneManager.LoadScene(2);
        }
    }
}
