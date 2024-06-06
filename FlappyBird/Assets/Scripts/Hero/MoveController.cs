using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    [SerializeField] private float flapForce = 300f;
    [SerializeField] private float forwardSpeed = 2f;
    private Rigidbody2D rb;
    private TapDetector tapDetector;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tapDetector = GetComponent<TapDetector>();
    }

    private void Update()
    {
        if (tapDetector.IsTapDetected())
        {
            Flap();
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(forwardSpeed, rb.velocity.y);
    }

    void Flap()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        rb.AddForce(new Vector2(rb.velocity.x, flapForce));
    }
}
