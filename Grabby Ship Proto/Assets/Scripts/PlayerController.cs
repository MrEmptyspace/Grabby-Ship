
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Something in this script is changing the Y value of the player
    //I've Froze transform.y to fix this (RigidBody->Constaints)

    public float moveSpeed;
    private Rigidbody myRigidbody;
    private Vector3 moveInput;
    private Vector3 moveVelocity;
    public Plane groundPlane;
    private Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        mainCamera = FindObjectOfType<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //moveInput = new Vector3(Input.GetAxis("Horizontal")) This has smoothing applied to it
        moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput * moveSpeed;

        Ray cameraRay = mainCamera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(cameraRay.origin,Vector3.forward,Color.red);

        RaycastHit hit;
        if (Physics.Raycast(cameraRay, out hit,30))
        {
            Vector3 pointToLook = cameraRay.GetPoint(hit.distance);
            Debug.DrawLine(cameraRay.origin, pointToLook, Color.green);
            transform.LookAt(new Vector3(pointToLook.x, transform.position.y, pointToLook.z));
        }          
    }

    void FixedUpdate()
    {
        myRigidbody.velocity = moveVelocity;
        //myRigidbody
    }
}