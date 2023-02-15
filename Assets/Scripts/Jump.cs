using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    const int MAX_JUMPS = 2;
    public int jumpCount = 0;
    Rigidbody2D rb;
    public float force;
    GroundDetector groundDetector;

    // Start is called before the first frame update
    void Start()
    {
        groundDetector = GetComponent<GroundDetector>();
        jumpCount = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (!PauseMenu.instance.isPaused)
            if (Input.GetButtonDown("Jump"))
            {
                if (groundDetector.grounded)
                {
                    jumpCount = 0;
                }
                if (jumpCount < MAX_JUMPS)
                {
                    jumpCount++;
                    rb.AddForce(Vector2.up * force);
                }
            }
    }
}
