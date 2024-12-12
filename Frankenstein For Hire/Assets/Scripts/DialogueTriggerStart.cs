using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using Yarn.Unity;

public class DialogueTriggerStart : MonoBehaviour, IPointerClickHandler
{
    public string DialogueStartNode;
    private DialogueRunner dialogueRunner;
    public bool interactable;
    private bool isCurrentConversation;
    public GameObject self;
    public enum TriggerType
    {
        UIButton,
        IsoCollison,
      
    }
    [SerializeField] private TriggerType triggerType;

    private void Start()
    {
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        dialogueRunner.onDialogueComplete.AddListener(EndConversation);
    }

    private void Update()
    {
        if(triggerType == TriggerType.UIButton && interactable && !dialogueRunner.IsDialogueRunning)
        {
            if (Input.GetMouseButtonDown(0) & EventSystem.current.IsPointerOverGameObject())
              {
                    
                    //interactable = false; //should keep from reactivation`
                
            }
            
        }
    }

    private void StartConversation()
    {
       // begin animation or turn on speaker indicator for iso sprites
        isCurrentConversation = true;
        dialogueRunner.StartDialogue(DialogueStartNode);
        

    }
    private void EndConversation()
    {
        if (isCurrentConversation)
        {
            //stop animation or turn off indicator or whatever
            isCurrentConversation = false;
            Debug.Log("Dialogue ended");
        }
    }
    
 
   
  //  public GameObject Panel;
    public void OnPointerClick(PointerEventData eventData)
    {
   


        if (triggerType == TriggerType.UIButton && interactable && !dialogueRunner.IsDialogueRunning)
        {
            //Panel.SetActive(true);
            StartConversation();
            Debug.Log("Dialogue start via button");
        }
    }
  
}
 