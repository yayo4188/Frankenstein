using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class ButtonControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject StartGame;
    public GameObject Endassembly;

    public GameObject BodyManager;

    public GameObject interrogationUI;
    public GameObject AltUI;

    [YarnCommand("disableButton")] //call in yarn as <<disabledialogue [name here]>> in a node to stop charcter from being talked to
    public void disableButton(string ButtonName)
    {
        if(ButtonName == "StartGame")
        {
            StartGame.SetActive(false);
        }
        else if(ButtonName == "Endassembly")
        {
            Endassembly.SetActive(false);
        }
    }


    [YarnCommand("enableButton")] //call in yarn as <<disabledialogue [name here]>> in a node to stop charcter from being talked to
    public void enableButton(string ButtonName)
    {
        if (ButtonName == "StartGame")
        {
            StartGame.SetActive(true);
        }
        else if (ButtonName == "Endassembly")
        {
            Endassembly.SetActive(true);
        }
    }

    [YarnCommand("BodyBuild")] //call in yarn as <<disabledialogue [name here]>> in a node to stop charcter from being talked to
    public void BodyBuild(string Mode)
    {
        if (Mode == "true")
        {
            BodyManager.SetActive(true);
        }
        else if (Mode == "false")
        {
            BodyManager.SetActive(false);
        }
    }


    [YarnCommand("SceneChange")] //call in yarn as <<disabledialogue [name here]>> in a node to stop charcter from being talked to
    public void SceneChange(string Scene)
    {
        if (Scene == "Body")
        {
            interrogationUI.SetActive(false);
        }
        else if (Scene == "Interrogation")
        {
            interrogationUI.SetActive(true);
        }
    }

}
