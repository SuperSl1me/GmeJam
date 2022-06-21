using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float normalSpeed = 2f;
    private float initialSpeed;
    [SerializeField] private float sprintSpeed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        initialSpeed = normalSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");



        if (Input.GetKey(KeyCode.LeftShift))
        {
            normalSpeed = sprintSpeed;
            Debug.Log("Sprinting");
        }
        else
        {
            normalSpeed = initialSpeed;
        }

        float moveX = horizontalInput * normalSpeed * Time.deltaTime;
        float moveY = verticalInput * normalSpeed * Time.deltaTime;
        transform.Translate(moveX, moveY, 0);
    }
}
