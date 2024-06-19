using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
public class Player : MonoBehaviour
{
    CharacterController characterController;
    Animator anim;
    [SerializeField] private float speed;

    public GameObject bullet;
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
        shoot();
    }

    void movement(){
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            characterController.Move(Vector3.left * speed * Time.deltaTime);
            anim.SetBool("Left",true);
            anim.SetBool("Right",false);
        }else if(Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.LeftArrow)){
            characterController.Move(Vector3.right * speed * Time.deltaTime);
            anim.SetBool("Left",false);
            anim.SetBool("Right",true);
        }
    }

    void shoot(){
        if(Input.GetMouseButtonDown(0) || Input.GetKey(KeyCode.Space)){
            var bulletClone = Instantiate(bullet);
            bulletClone.transform.position = gameObject.transform.position;
        }

    }
}
