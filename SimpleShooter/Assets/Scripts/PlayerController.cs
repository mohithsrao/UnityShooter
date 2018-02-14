using System;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    Vector3 velocity;
    Rigidbody myRigiBody;

    // Use this for initialization
    void Start()
    {
        myRigiBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        myRigiBody.MovePosition(myRigiBody.position + velocity * Time.fixedDeltaTime);
    }

    public void Move(Vector3 moveVelocity)
    {
        velocity = moveVelocity;
    }

    public void LookAt(Vector3 lookPoint)
    {
        Vector3 elevatedPoint = new Vector3(lookPoint.x, transform.position.y, lookPoint.z);
        transform.LookAt(elevatedPoint);
    }
}
