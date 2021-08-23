using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GarbageCollect : MonoBehaviour
{
    public PlayerMovementAndInfo player;

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(Input.GetKey(KeyCode.E))
            Destroy(gameObject);
        }
    }
}
