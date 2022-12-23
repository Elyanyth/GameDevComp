using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{

    public Rigidbody2D player;
    Rigidbody2D cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (cam.position != player.position){
            transform.position = new Vector3(player.position.x, player.position.y, -10);
        }
    }
}
