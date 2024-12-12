using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using Yarn.Unity;
using static System.TimeZoneInfo;

public class THEBUTTON : MonoBehaviour
{
    // Start is called before the first frame update
  //  public GameObject DialogueRun;
   // public GameObject Event;
    public string sceneName;
    public int transitionTime; 
    void Start()
    {
        
    }
    public void GoToScene()
    {
        
        StartCoroutine(LoadScene());
    }
    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneName);
    }

    private void Update()
    {
            if (Input.GetMouseButtonDown(0) & EventSystem.current.IsPointerOverGameObject())
            {
            // DialogueRun.SetActive(true);
             StartCoroutine(LoadScene());
        }

        
    }
}
