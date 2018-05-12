using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerRigidbody : MonoBehaviour {

    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";
    
    public bool isMaxSpeed = false;
    public float maxSpeed = 100;
    public float rotationRate = 360;
    public float moveSpeed = 10;

    private Rigidbody rb;

    public Camera m_Camera;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update () {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);
        if (moveSpeed >= maxSpeed)
        {
            isMaxSpeed = true;
        }

        ApplyInput(moveAxis, turnAxis);
	}
    
  

    private void ApplyInput(float moveInput,
                            float turnInput)
    {
        Move(moveInput);
        Turn(turnInput);
    }
    
    private void Move(float input)
    {
        //transform.Translate(Vector3.forward * input * moveSpeed);
        if (!isMaxSpeed){
            rb.AddForce(transform.forward * input * moveSpeed, ForceMode.Force);
        }
    }

    private void Turn(float input)
    {
        Vector3 m_CameraForward = m_Camera.transform.forward;
        m_CameraForward.y = 0;
        m_CameraForward.Normalize();
        transform.LookAt(transform.position + m_CameraForward);
        transform.Rotate(0, (-input) * rotationRate * Time.deltaTime, 0);
        rb.AddForce(transform.right * input * moveSpeed, ForceMode.Force);
    }
}
