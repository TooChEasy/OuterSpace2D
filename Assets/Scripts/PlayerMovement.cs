using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
   
    public float moveSpeed = 1f;
    public float rotationSpeed = 720f;
    IsometricCharacterRenderer isoRenderer; 
    public Rigidbody2D rbody;

    private void Awake() {
        rbody = GetComponent<Rigidbody2D>();
        isoRenderer = GetComponentInChildren<IsometricCharacterRenderer>();
    }

    // private void Update() {
        
    // }

    private void FixedUpdate() {
        Vector2 currentPos = rbody.position;
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        input = Vector2.ClampMagnitude(input, 1);
        Vector2 movement = input * moveSpeed;
        Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;

        rbody.MovePosition(newPos);
        // if (input == Vector2.zero) return;
        // Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, input);
        // transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.fixedDeltaTime);
    }

}
