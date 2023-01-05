using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Lock : XRSocketInteractor
{
    public HingeJoint hinge;

    public string targetTag;

    public int unlockLimit = 90;
    public int lockLimit = 10;

    [System.Obsolete]
    public override bool CanHover(XRBaseInteractable interactable)
    {
        return base.CanHover(interactable) && MatchUsingTag(interactable);
    }

    [System.Obsolete]
    public override bool CanSelect(XRBaseInteractable interactable)
    {
        return base.CanSelect(interactable) && MatchUsingTag(interactable);
    }

    private bool MatchUsingTag(XRBaseInteractable interactable)
    {
        return interactable.CompareTag(targetTag);
    }

    public void UnlockIt()
    {
        JointLimits limits = hinge.limits;

        limits.max = unlockLimit;
        hinge.limits = limits;
    }

    public void LockIt()
    {
        JointLimits limits = hinge.limits;

        limits.max = lockLimit;
        hinge.limits = limits;
    }
}
