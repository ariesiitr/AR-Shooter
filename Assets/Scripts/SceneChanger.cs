using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource select;
    private void Awake()
    {
        select = GetComponent<AudioSource>();
    }
    public void OnStart()
    {
        select.Play();

        StartCoroutine(LoadScene2());

    }

    IEnumerator LoadScene2()
    {
        
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Scene2");
    }
    public void OnExit()
    {
        select.Play();
        Application.Quit();
    }
}
