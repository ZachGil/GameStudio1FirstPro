using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class BallPlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigid;

    // Enable movement on collision
    public bool isAbleToMove = false;

    public float xInput = 0;

    // A/b Test input methods. 
    public bool testing_UseForce = true;
    public float forceAmount = 1f;

    public bool testing_UseTorque = false;
    public float torqueAmount = 1f;

    public void Awake() {
        // Gets a reference to the rigidbody. 
        rigid = GetComponent<Rigidbody2D>();
        // Usually I would check this is working, however we added the require to the top of the script so unity checks for us. 
        // you could check though: 

        if(rigid == null) {
            Debug.LogWarning("No Rigidbody reference found in BallPlayerMovement");
        }

    }

    // Update is called once per frame
    void Update()
    {
        xInput = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate() {
        // Only move if this == true
        if (isAbleToMove) {
            // Add force (world orientation) on x axis
            if (testing_UseForce) {
                rigid.AddForce(new Vector2(xInput, 0) * forceAmount);
            }
            // Add Torque instead. 
            if (testing_UseTorque) {
                rigid.AddTorque(xInput * torqueAmount);
            }
            // [ ] test a decide (or mix and match), what are the differences? 
        }

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        isAbleToMove = true;
    }

}
