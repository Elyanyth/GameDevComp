using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{

    Vector3 playerPos;
    Vector3 camPos;

    // Start is called before the first frame update
    void Start()
    {
        camPos = gameObject.GetComponent<Rigidbody2D>().position;

        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").gameObject.GetComponent<Rigidbody2D>().position;
        if (camPos != playerPos){
            transform.position = new Vector3(playerPos.x, playerPos.y, -10);
        }
    }
}
