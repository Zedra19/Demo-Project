using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = FindAnyObjectByType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
       transform.position += Vector3.forward * bulletSpeed * Time.deltaTime;
       Destroy(gameObject, 3f);
    }

    void OnTriggerEnter(){
        score.AddScore();
        Destroy(gameObject);
    }
}
