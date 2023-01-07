using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    [SerializeField] GameObject panel = null;

    private void Start()
    {
        panel.SetActive(false);
    }
    public void gamestart()
    {
        panel.SetActive(true);
    }
    public void panelcolse()
    {
        panel.SetActive(false);
    }
    public void sceneplay1()
    {
        SceneManager.LoadScene(3);
    }
    public void sceneplay2()
    {
        SceneManager.LoadScene(4);
    }
    public void sceneplay3()
    {
        SceneManager.LoadScene(5);
    }
    public void sceneplay4()
    {
        SceneManager.LoadScene(6);
    }
    public void randomscene()
    {
        SceneManager.LoadScene(Random.Range(3, 6));
    }
}
