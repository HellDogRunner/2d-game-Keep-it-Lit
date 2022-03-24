using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    float horizmove = 0f;
    public float runspeed = 40f;
    bool crouch = false;
    bool jump = false;
    public Animator anim;
    //public bool IsMoving { private get; set; }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizmove= Input.GetAxisRaw("Horizontal")*runspeed;
        if (Input.GetButtonDown("Jump")) {

            jump = true;
            anim.SetTrigger("Air");
        }
        if (Input.GetButtonDown("Fire3"))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z + 10);
            gameObject.layer = 12;
        }
        if (Input.GetButtonDown("Fire2"))
        {
            this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z - 10);
            gameObject.layer = 11;
        }
        if (Input.GetButtonDown("Crouch"))
        {

            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;

        }
    }
    private void FixedUpdate()
    {
        if ((horizmove != 0) && (Input.GetButtonDown("Jump")))
        {
            anim.SetTrigger("Air");
        }
        if (horizmove != 0)
        {
            anim.SetBool("IsMoving", false);
        }
        if (horizmove==0)
            anim.SetBool("IsMoving", true);
        controller.Move(horizmove* Time.fixedDeltaTime,crouch,jump);
        jump = false;  
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Shipi")
        {
            this.transform.position = new Vector3(-9, -8, 0);
            gameObject.layer = 11;
        }
    }
}
