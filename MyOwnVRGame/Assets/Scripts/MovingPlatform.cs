using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed;
    public Transform position1;
    public Transform position2;
    public Rigidbody rb;

    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = position1.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector3 direction = (targetPosition - rb.position).normalized;
        rb.MovePosition(rb.position + speed * direction * Time.fixedDeltaTime);

        if(Vector3.Distance(rb.position, targetPosition) < 0.05f){
            if(targetPosition == position1.position)
            {
                targetPosition = position2.position;
            }
            else
            {
                targetPosition = position1.position;
            }
        }
    }
}
