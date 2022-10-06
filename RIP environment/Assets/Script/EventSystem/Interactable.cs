using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //add or remove an InteractionEvent component to this gameobject.
    public bool useEvents;
    [SerializeField]
    public string promptMessage;

    public virtual string OnLook()
    {
        return promptMessage;
    }

    public void BaseInteract()
    {
        if (useEvents)
            GetComponent<InteractionEvent>().OnInteract.Invoke();
        Interact();
    }

    protected virtual void Interact()
    {
        //This will be overidden by a subclass cuz it is a template
    }

}
