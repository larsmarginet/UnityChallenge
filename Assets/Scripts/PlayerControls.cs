using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class PlayerControls : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;

    public float verticalSpeed = 2.0f;
    public float horizontalSpeed = 2.0f;
    private float horizontalInput;
    private float forwardInput;

    public bool isGrounded;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);

    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }


    void Update()
    {
        //move on x axis
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed * forwardInput);

        //move on z axis
        forwardInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalSpeed * horizontalInput);

        //jump on y axis
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}

