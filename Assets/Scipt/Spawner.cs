using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class Spawner : MonoBehaviour
{
    public GameObject cow;
    public GameObject deer;
    public GameObject horse;
    [SerializeField] float timer = 0f;
    [SerializeField] float spawnEverySecond = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= spawnEverySecond){
            var mobs = Random.Range(1 , 3);
            if (mobs == 1){
                var mobsClone = Instantiate(cow);
                var getRandomPosX = Random.Range(-4f,4f);
                mobsClone.transform.position = new Vector3(getRandomPosX,transform.position.y, transform.position.z);
            }else if(mobs == 2){
                var mobsClone = Instantiate(deer);
                var getRandomPosX = Random.Range(-4f,4f);
                mobsClone.transform.position = new Vector3(getRandomPosX,transform.position.y, transform.position.z);
            }else if(mobs == 3){
                var mobsClone = Instantiate(horse);
                var getRandomPosX = Random.Range(-4f,4f);
                mobsClone.transform.position = new Vector3(getRandomPosX,transform.position.y, transform.position.z);
            }
        }
    }
}
