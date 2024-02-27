using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    public Weapon weapon;

    Vector2 moveDirection;
    Vector2 mousePosition;
    

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float movey = Input.GetAxisRaw("Vertical");

        if (Input.GetMouseButtonDown(0))
        {
            weapon.Fire();
        }

        moveDirection = new Vector2 (moveX, movey).normalized;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
    }


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed , moveDirection.y * moveSpeed);

        Vector2 aimDirection = mousePosition - rb.velocity;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Deg2Rad - 90f;
        rb.rotation = aimAngle;
    }

}
