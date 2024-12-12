using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn;
using Yarn.Unity;

public class LimbChecker : MonoBehaviour

{  //body 
    public Collider leftArmC;
    public Collider RightArmC;
    public Collider leftLegC;
    public Collider RightLegC;
    public Collider HeadC;


    InMemoryVariableStorage variableStorage;


    //tag teams with collider checker
    [YarnCommand("LimbsClear")]
    public void LimbClear() //emptys list/only if needed/call at the end of every intergation 
    {
     
    }
   
    [YarnCommand("LimbsSlot")] //takes a slot name and check that limbs and takes its name as a string 
    public void LimbsSlot(string LSlot)
    {
        //Takes the name of a slot and check the tag of the object in it and spits it out to Yarn as a string which gets put in a <<jump to>> 
        //ask cherie to help
        Debug.Log("LimbsSlot Triggered");
        if (LSlot == "LeftArm")
        {
            Debug.Log("LimbsSlot Triggered");
            //find a way to send to yarn
            variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
            string bodyJump;
            variableStorage.TryGetValue("$BodyJump", out bodyJump);
            variableStorage.SetValue("$BodyJump", bodyJump = leftArmC.GetComponent<ColliderChecker>().Limb);
            
            Debug.Log("Jumping to " + LSlot);
        }
        else if (LSlot == "RightArm")
        { 

            variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
            string bodyJump;
            variableStorage.TryGetValue("$BodyJump", out bodyJump);
            variableStorage.SetValue("$BodyJump", bodyJump = RightArmC.GetComponent<ColliderChecker>().Limb);

            Debug.Log("Jumping to" + LSlot);
        }
        else if (LSlot == "LeftLeg")
        {
           
            variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
            string bodyJump;
            variableStorage.TryGetValue("$BodyJump", out bodyJump);
            variableStorage.SetValue("$BodyJump", bodyJump = leftLegC.GetComponent<ColliderChecker>().Limb);

            Debug.Log("Jumping to" + LSlot);
        }
        else if (LSlot == "RightLeg")
        {

            variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
            string bodyJump;
            variableStorage.TryGetValue("$BodyJump", out bodyJump);
            variableStorage.SetValue("$BodyJump", bodyJump = RightLegC.GetComponent<ColliderChecker>().Limb);

            Debug.Log("Jumping to" + LSlot);
        }
        else if (LSlot == "Head")
        {

            variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
            string bodyJump;
            variableStorage.TryGetValue("$BodyJump", out bodyJump);
            variableStorage.SetValue("$BodyJump", bodyJump = HeadC.GetComponent<ColliderChecker>().Limb);

            Debug.Log("Jumping to" + LSlot);
        }
        else
        {
            variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
            string bodyJump;
            variableStorage.TryGetValue("$BodyJump", out bodyJump);
            variableStorage.SetValue("$BodyJump", bodyJump = "LimbEmpty");

            Debug.Log("Jumping to" + bodyJump);
        }
    }
   

    [YarnCommand("LimbsSet")] //checks all slots and check all limbs to see if they are full set, then gives yarn a which interragation to jump to 
    
    public void LimbsSet()
    {
        //if statments
        Debug.Log("LimbsSet Triggered");
        //body1 set
        if (leftArmC.GetComponent<ColliderChecker>().Limb == "Body1LeftArm" & RightArmC.GetComponent<ColliderChecker>().Limb == "Body1RightArm" 
            & leftLegC.GetComponent<ColliderChecker>().Limb == "Body1LeftLeg" & RightLegC.GetComponent<ColliderChecker>().Limb == "Body1RightLeg" 
            & HeadC.GetComponent<ColliderChecker>().Limb == "Body1Head")
        {
            variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
            string bodyJump;
            variableStorage.TryGetValue("$BodyJump", out bodyJump);
            variableStorage.SetValue("$BodyJump", bodyJump = "Body1RESTORED");
          

            Debug.Log("Body 1 FULLY RESTORED");
        }

        //Body2 set
        else if (leftArmC.GetComponent<ColliderChecker>().Limb == "Body2LeftArm" & RightArmC.GetComponent<ColliderChecker>().Limb == "Body2RightArm"
          & leftLegC.GetComponent<ColliderChecker>().Limb == "Body2LeftLeg" & RightLegC.GetComponent<ColliderChecker>().Limb == "Body2RightLeg"
          & HeadC.GetComponent<ColliderChecker>().Limb == "Body2Head")
        {

            variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
            string bodyJump;
            variableStorage.TryGetValue("$BodyJump", out bodyJump);
            variableStorage.SetValue("$BodyJump", bodyJump = "Body2RESTORED");

            Debug.Log("Body 2 FULLY RESTORED");
        }
        //Body3 set
         else if (leftArmC.GetComponent<ColliderChecker>().Limb == "Body3LeftArm" & RightArmC.GetComponent<ColliderChecker>().Limb == "Body3RightArm"
          & leftLegC.GetComponent<ColliderChecker>().Limb == "Body3LeftLeg" & RightLegC.GetComponent<ColliderChecker>().Limb == "Body3RightLeg"
          & HeadC.GetComponent<ColliderChecker>().Limb == "Body3Head")
        {

            variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
            string bodyJump;
            variableStorage.TryGetValue("$BodyJump", out bodyJump);
            variableStorage.SetValue("$BodyJump", bodyJump = "Body3RESTORED");

            Debug.Log("Body 3 FULLY RESTORED");
            
        }
        else
        {
            variableStorage = GameObject.FindObjectOfType<InMemoryVariableStorage>();
            string bodyJump;
            variableStorage.TryGetValue("$BodyJump", out bodyJump);
            variableStorage.SetValue("$BodyJump", bodyJump = "InterrogationStart");

            Debug.Log("Cadavar Contructed");

        }
    }

   
}
