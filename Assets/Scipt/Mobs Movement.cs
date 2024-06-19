using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobsMovement : MonoBehaviour
{
    Animator anim;
    [SerializeField] float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.back * speed * Time.deltaTime;
    }
}
