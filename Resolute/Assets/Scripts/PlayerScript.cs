using UnityEngine;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour {

    public int speed;

    void Start() {
        SpriteLoader sloader = GetComponent<SpriteLoader>();
        HealthScript hscript = GetComponent<HealthScript>();
        List<GameObject> dots = sloader.initSprite();
        hscript.initHealth(dots);
    }

    void FixedUpdate() {
        //Get keyboard input for the movement and calculate the player's velocity
        float horMove = Input.GetAxisRaw("Horizontal") * speed;
        Vector2 v = GetComponent<Rigidbody2D>().velocity;
        v.x = horMove;
        GetComponent<Rigidbody2D>().velocity = v; //Set the velocity
        if (Input.GetButtonDown("Fire1")) {
            GetComponent<HealthScript>().damage(1);
        }
    }
}
