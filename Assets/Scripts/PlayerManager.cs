using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10);
    private Vector2 movement;
    private Rigidbody2D rigidBodyComponent;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // 4 - Movement per direction
        movement = new Vector2(
          speed.x * inputX,
          speed.y * inputY);
    }

    void FixedUpdate()
    {
        if (rigidBodyComponent == null) 
            rigidBodyComponent = GetComponent<Rigidbody2D>();

        rigidBodyComponent.velocity = movement;
    }
}
