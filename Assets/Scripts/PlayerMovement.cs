using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    // movement from https://www.youtube.com/watch?v=hiXYyn9NkOo
    [Header("Movement")]
    public float walkSpeedDiff;
    public float moveSpeed;
    public Boolean gassed;

    public Transform orientation;

    float horizontalInput;
    float verticalInput;

    Vector3 moveDirection;

    Rigidbody rb;
    //public float Speed = 5f;

    public Image staminaBar;
    public float stamina, maxStamina;

    public Image sanityBar;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
        gassed = false;
    }

    private void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(moveDirection.normalized * moveSpeed * 10f, ForceMode.Force);

        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //charCon.Move(move * Time.deltaTime * Speed);

        if(moveDirection.magnitude > 0 && !gassed)
        {
            stamina -= 50*Time.deltaTime;
            if (stamina < 0)
            {
                stamina = 0;
                gassed = true;
                moveSpeed -= walkSpeedDiff;
            }
        }
        else
        {
            stamina += 30*Time.deltaTime;
            if (stamina > maxStamina)
            {
                stamina = maxStamina;
                if (gassed)
                {
                    gassed = false;
                    moveSpeed += walkSpeedDiff;
                }
            }
        }

        if (Input.GetKeyDown("f"))
        {
            sanityBar.color = new Color(sanityBar.color.r, sanityBar.color.b, sanityBar.color.g, sanityBar.color.a + 0.1f);
        }

        staminaBar.fillAmount = stamina / maxStamina;
    }
}
