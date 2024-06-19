using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class Player : MonoBehaviour
{
    Animator anim;
    CharacterController characterController;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }

    void movement(){
        if(Input.GetKey(KeyCode.A)){
            characterController.Move(Vector3.left * speed * Time.deltaTime);
            anim.SetBool("Left",true);
            anim.SetBool("Right",false);
        }else if(Input.GetKey(KeyCode.D)){
            characterController.Move(Vector3.right * speed * Time.deltaTime);
            anim.SetBool("Left",false);
            anim.SetBool("Right",true);
        }
    }

    void shoot(){

    }
}
