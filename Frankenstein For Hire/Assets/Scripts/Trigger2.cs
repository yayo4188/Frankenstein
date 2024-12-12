using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Yarn.Unity;

public class Trigger2 : MonoBehaviour
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

    //will need to change function to call via juns buttons

    private void Start()
    {
        dialogueRunner = FindObjectOfType<Yarn.Unity.DialogueRunner>();
        dialogueRunner.onDialogueComplete.AddListener(EndConversation);
    }

    private void Update()
    {
        if (triggerType == TriggerType.UIButton && interactable && !dialogueRunner.IsDialogueRunning)
        {
            if (Input.GetMouseButtonDown(0) & EventSystem.current.IsPointerOverGameObject())
            {
                StartConversation();
                Debug.Log("Dialogue start via button");
                interactable = false; //should keep from reactivation`

            }

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (triggerType == TriggerType.IsoCollison && interactable && !dialogueRunner.IsDialogueRunning)
        {
            if (collision.gameObject.tag == "Player")
            {
                StartConversation();
                Debug.Log("Dialogue start via collision");
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

  

}
