using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static DialogueTriggerStart;
using UnityEngine.EventSystems;
using Yarn.Unity;

public class DialogueProgressSkip : MonoBehaviour
{
    // Start is called before the first frame update
    private DialogueRunner dialogueRunner; //!dialogueRunner.IsDialogueRunning if we need to make sure it only triggers when dialogue running but probs not
    public GameObject BoxToClick;//may not be needed
   //ublic int BoxClicks;
    public LineView lineView;
    
 

    // Update is called once per frame
    private void Update()
    {
            if (Input.GetMouseButtonDown(0) & EventSystem.current.IsPointerOverGameObject())
            {
            
                
                lineView.OnContinueClicked();

      
            }

        //scroll skip, have roll top/disable when you get to a option #lastline tag yarn uses
    }
}
