using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AttachBeltToBody : XRSocketInteractor
{
    public string targetTag;

    private bool isRightTag;

    [System.Obsolete]
    public override bool CanHover(XRBaseInteractable interactable)
    {
        isRightTag = MatchUsingTag(interactable);
        return base.CanHover(interactable) && isRightTag;
    }

    [System.Obsolete]
    public override bool CanSelect(XRBaseInteractable interactable)
    {
        isRightTag = MatchUsingTag(interactable);
        return base.CanSelect(interactable) && isRightTag;
    }

    private bool MatchUsingTag(XRBaseInteractable interactable)
    {
        return interactable.CompareTag(targetTag);
    }
}
