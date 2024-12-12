using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class Buttonscenetrans : MonoBehaviour
{
    public Animator transition;
    public Animator loadfile;
    public float transitionTime;
    public string sceneName;
    public GameObject Pause;

    AudioManager audiomanager;
    private void Awake()
    {
        audiomanager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }
    public void Loadfile()
    {
        loadfile.SetTrigger("in");
    }
    public void GoToScene()
    {
        audiomanager.PlaySFX(audiomanager.sfx);
        StartCoroutine(LoadScene());
    }
   IEnumerator LoadScene()
    {
        transition.SetTrigger("Transition");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneName);
    }
    public void GoToScene2()
    {

        StartCoroutine(LoadScene2());
    }
    IEnumerator LoadScene2()
    {
        audiomanager.PlaySFX(audiomanager.sfx);
        transition.SetTrigger("Transition");
        yield return new WaitForSeconds(transitionTime);
        if (Pause.activeSelf)
        {
            Pause.SetActive(false);
        }
        else
        {
            Pause.SetActive(true);
        }
    }
    public void QuitApp()
    { 
        Application.Quit();
        Debug.Log("Quit");
    }
}
