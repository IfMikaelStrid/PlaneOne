using UnityEngine;
using System.Collections;

public class planeController : MonoBehaviour
{
    public float RotationSpeed;
    public float ThrustForce;
    public Rigidbody2D rb;
    public float maxSpeed = 50f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        // Trying to Limit Speed
        if (rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, maxSpeed);
        }
    }

        void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //rb.angularVelocity = RotationSpeed;
            rb.transform.Rotate(0, 0, -6f);
            //rb.transform.Rotate(0, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //rb.angularVelocity = -RotationSpeed;
            rb.transform.Rotate(0, 0, 6f);
            //rb.transform.RotateAround(transform.position, transform.up, Time.deltaTime + 90f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(transform.up * ThrustForce);
        }
    }
}
