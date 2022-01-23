using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 1000;
    public float gravityModifier = 2;
    public bool onTheGround = true;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();   
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onTheGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onTheGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        onTheGround = true;
    }
}
