using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class InventorySocketManagment : MonoBehaviour
{
    XRSocketInteractor socket;
    Rigidbody rb;

    private void Start()
    {
        socket = GetComponent<XRSocketInteractor>();

    }

    public void SocketCheck()
    {
        IXRSelectInteractable objName = socket.GetOldestInteractableSelected();

        rb = objName.transform.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.isKinematic = false;
                
        Debug.Log($"{objName.transform.name} in socket of {transform.name}");
    }
}
