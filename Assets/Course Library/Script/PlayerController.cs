using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rBody;
    public float jumpForce = 10f;
    public float gravityModifier;
    public bool isGrounded = true;

    void Start()
    {
        rBody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
}
