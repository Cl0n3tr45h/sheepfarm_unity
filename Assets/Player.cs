﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float moveSpeed = 4f;
    public Transform movePoint; //Point to where the player WILL move

    public LayerMask whatStopsMovement;

    // Start is called before the first frame update
    void Start () {
        movePoint.parent = null; //to ensure independent movement but keep it nice and orlderly in the project view
    }

    // Update is called once per frame
    void Update () {

        checkMovement();
        
        transform.position = Vector3.MoveTowards (transform.position, movePoint.position, moveSpeed * Time.deltaTime);

       
    }

    void checkMovement(){
         if (Vector3.Distance (transform.position, movePoint.position) <= .05f) {

            if (Mathf.Abs (Input.GetAxisRaw ("Horizontal")) == 1f) {

                if (!Physics2D.OverlapCircle (movePoint.position + new Vector3 (Input.GetAxisRaw ("Horizontal"), 0f, 0f), .2f, whatStopsMovement)) {

                    movePoint.position += new Vector3 (Input.GetAxisRaw ("Horizontal"), 0f, 0f);

                }
            } else if (Mathf.Abs (Input.GetAxisRaw ("Vertical")) == 1f) {

                if (!Physics2D.OverlapCircle (movePoint.position + new Vector3 (0f, Input.GetAxisRaw ("Vertical"), 0f), .2f, whatStopsMovement)) {                
                    movePoint.position += new Vector3 (0f, Input.GetAxisRaw ("Vertical"), 0f);
                }
            }
        }
    }
}