using UnityEngine;

public class jumpforce : MonoBehaviour
{
    public float jumpForce = 10f;  // The force applied when the player jumps
    private Rigidbody rb;          // Reference to the player's Rigidbody component

    void Start()
    {
        // Get the Rigidbody component when the script starts
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the player presses the jump button (spacebar by default)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jumping!");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}