using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    public int maxHealth = 100;
    public int currentHealth;
    public HealthBar = healthBar;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    void Start() {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }  

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        } 
        else if (Input.GetButtonDown("Crouch"))
        {
            crouch = false;
        }

        // Test damage
        if(Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(20);
        }

    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
