using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; //Scene management so we can switch scenes

public class PlayerControllerRigidbody : MonoBehaviour {

    private string moveInputAxis = "Vertical";
    private string turnInputAxis = "Horizontal";

    private float startHealth = 100f;
    public float health = 100f;
    public bool isMaxSpeed = false;
    public float maxSpeed = 100;
    public float rotationRate = 360;
    public float moveSpeed = 10;
    public Image healthBar;

    bool levelCompleted = false;

    private Rigidbody rb;
    public Camera m_Camera;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        GetComponent<Score>().loadScore();
        
    }

    // Update is called once per frame
    void Update () {
        float moveAxis = Input.GetAxis(moveInputAxis);
        float turnAxis = Input.GetAxis(turnInputAxis);
        if (moveSpeed >= maxSpeed)
        {
            isMaxSpeed = true;
        }

        if(Input.GetButton("Cancel"))
        {
            Application.Quit();
            Debug.Log("The Application will exit");
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
        transform.Rotate(0, input * rotationRate * Time.deltaTime, 0);
        rb.AddForce(-(transform.right) * input * moveSpeed, ForceMode.Force);
    }

    public void Damage(float damage)
    {
        health -= damage;
        healthBar.fillAmount = health / startHealth;
        if (health <= 0f)
        {
            GameOver();
        }
    }
        
    void GameOver()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(2); //Load the Main Menu
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Objective")
        {
            Debug.Log("Objective Complete");
            levelCompleted = true;
            SceneManager.LoadScene(1);
            GetComponent<Score>().saveScores();
        }
    }
}
