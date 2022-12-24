using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{

    public string DoorName = "a";
    public bool state = false; // open is true and closed is false
    public float ClosingDistance = 10f;
    bool temp;
    bool close;

    GameObject player;
    GameObject HotBar;

    // Start is called before the first frame update
    void Start()
    {
        temp = state;

        player = GameObject.FindGameObjectWithTag("Player");

        HotBar = GameObject.FindGameObjectWithTag("HotBar");
    }

    // Update is called once per frame
    void Update()
    {
        if (HotBar.transform.childCount == 1)
        {
            GameObject Key = HotBar.transform.GetChild(0).gameObject;

            string ObjName = HotBar.transform.GetChild(0).name;

            if (DoorName == "")
            {
                interact();
            }
            else if (ObjName == "Key(Clone)" && Key.GetComponent<Key>().KeyName == DoorName)
            {
                interact();
            }
        }
        else
        {
           if (DoorName == "")
            {
                interact();
            } 
        }
        
        float distance = Vector3.Distance (gameObject.transform.position, player.transform.position);

        if (distance > ClosingDistance)
        {
            state = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        close = true;
    }

        private void OnTriggerExit2D(Collider2D other)
    {
        close = false;
    }

    void interact()
    {
        if (close == true)
        {
            if (Input.GetKeyDown("e"))
            {
                state = !state;
            }
        }

        if (temp != state)
        {
            if (state == true)
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = false;
            }
            else
            {
                gameObject.GetComponent<BoxCollider2D>().enabled = true;
            }
            temp = state;
        }
    }
}
