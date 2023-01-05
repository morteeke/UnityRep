using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBullet : MonoBehaviour
{

    public GameObject bullet;
    public Transform spawnPoint;
    public float bulletSpeed = 10;

    public AudioSource fireSound;

    public BulletCounter bulletCounter;

    // Start is called before the first frame update
    void Start()
    {
        //We want to use the xrgrabinteractable of this gameobject.
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();
        //when the grabbable gets activated with the trigger button, start Fire method.
        grabbable.activated.AddListener(Fire);

        //Make variable for BulletCounter script.
        //bulletCounter = GetComponent<BulletCounter>();
    }

    public void Fire(ActivateEventArgs arg)
    {
        //creat an instance of bullet.
        GameObject spawnedBullet = Instantiate(bullet);
        //set the position of the instantiated bullet to the spawnpoint.
        spawnedBullet.transform.position = spawnPoint.position;
        //set the velocity of the spawned bullet with its rigidbody.
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * bulletSpeed;

        //activate fire sound.
        fireSound.Play();

        //Add to counter in 'BulletCounter' script.
        bulletCounter.IncreaseCounter();

        //destroy the instantiated bullet after 5 seconds.
        Destroy(spawnedBullet, 5);
    }
}
