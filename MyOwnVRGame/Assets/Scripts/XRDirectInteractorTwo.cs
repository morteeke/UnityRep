using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRDirectInteractorTwo : XRDirectInteractor
{
    public BoxCollider bc;

    public void EnableCollision()
    {
        bc.enabled = true;
    }

    public void DisableCollision()
    {
        bc.enabled = false;
    }
}
