using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveForce;
    public float jumpForce;

    public float maximumDim = 10f;
    public float shapeshiftSpeed;

    Rigidbody rb;

    Collider ground = null;

    [SerializeField]
    float t = 1f; // length can always be derived by (sqrt(t^2 + 4) - t) / 2

    public float shapeLength
    {
        get
        {
            return 0.5f * (Mathf.Sqrt(t * t + 4f) - t);
        }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0f)
            rb.AddForce(Vector3.right * Input.GetAxis("Horizontal") * moveForce * shapeLength);

        if (Input.GetButton("Vertical") && ground != null)
            rb.AddForce(Vector3.up * jumpForce * (4f * Mathf.Exp(-shapeLength) * (1f - Mathf.Exp(-shapeLength))), ForceMode.Impulse);

        if (Input.GetAxis("Shapeshift") != 0f)
        {
            //TODO shapeshift audio perhaps?
            t = Mathf.Clamp(t + Input.GetAxis("Shapeshift") * shapeshiftSpeed, -maximumDim, maximumDim);

            transform.localScale = new Vector3(shapeLength, 1f / shapeLength, 1);
        }
       
    }

  


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.contactCount > 0 && collision.GetContact(0).point.y < rb.position.y)
            ground = collision.gameObject.GetComponent<Collider>();
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.Equals(ground))
            ground = null;
    }
}
