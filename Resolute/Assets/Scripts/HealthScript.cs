using UnityEngine;
using System.Collections.Generic;
using System;

public class HealthScript : MonoBehaviour {

    public List<GameObject> pixels = new List<GameObject>();
    public int health;
    private System.Random rand = new System.Random();
    public GameObject gravityDot;

    public void damage(int amnt) {
        for (int i = amnt; i > 0; i--) {
            int intToDrop = rand.Next(pixels.Count - 1);
            GameObject dotToDrop = pixels[intToDrop];
            GameObject dot = Instantiate(gravityDot) as GameObject;
            dot.transform.position = dotToDrop.transform.position;
            Vector2 v = new Vector2(UnityEngine.Random.Range(-3.0f, 3.0f), 5f);
            dot.GetComponent<SpriteRenderer>().color = dotToDrop.GetComponent<SpriteRenderer>().color;
            dot.GetComponent<Rigidbody2D>().velocity = v;
            float shadeGrey = UnityEngine.Random.Range(0.0f, 0.5f);
            dotToDrop.GetComponent<SpriteRenderer>().color = new Color(shadeGrey, shadeGrey, shadeGrey, 0.5f);
            pixels.RemoveAt(intToDrop);
            health--;
        }
    }

    public void initHealth(List<GameObject> dots) {
        pixels = dots;
        health = dots.Count;
    }
}
