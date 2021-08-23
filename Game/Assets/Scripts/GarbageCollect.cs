using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GarbageCollect : MonoBehaviour
{
    public Text text;
    public GameObject gb;
    bool collided = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && collided)
        {
            Destroy(gb);
        }
        if (!collided)
        {
            text.text = "";
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject player = collision.collider.gameObject;
        if (player.GetComponent<PlayerMovementAndInfo>())
        {
            text.text = "Press E To Remove It";
        }
        else
        {
            Debug.Log("WTF why not");
        }
    }
}
