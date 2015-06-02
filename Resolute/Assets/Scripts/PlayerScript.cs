using UnityEngine;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour {

    public int speed;
    public  List<GameObject> pixels = new List<GameObject>();

    void FixedUpdate()
    {
        //Get keyboard input for the movement and calculate the player's velocity
        float horMove = Input.GetAxisRaw("Horizontal") * speed;
        Vector2 v = GetComponent<Rigidbody2D>().velocity;
        v.x = horMove;
        GetComponent<Rigidbody2D>().velocity = v; //Set the velocity
    }
}
