using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour {

    public enum RotationAxes { MouseXandY = 0, MouseX = 1, MouseY =2 } //Set rotation axes
    public RotationAxes axes = RotationAxes.MouseXandY;
    public float sensitivityX = 15f; //Set sensitivity for X
    public float sensitivityY = 15f; //Set sensitivity for y

    public float minimumX = -360f;
    public float maximumX = 360f;

    public float minimumY = -60f;
    public float maximumY = 60f;

    float rotationY = 0f;

    public GameObject Player;
    public Vector3 m_OffSet;

    // Use this for initialization
    void Start () {
        Cursor.lockState = CursorLockMode.Locked;

        //m_OffSet = transform.position - Player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivityX;

        rotationY += Input.GetAxis("Mouse Y") * sensitivityY;
        rotationY = Mathf.Clamp(rotationY, minimumY, maximumY);

        transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }

    void LateUpdate()
    {
        //move camera with player
        transform.position = Player.transform.position + m_OffSet;
    }

}
