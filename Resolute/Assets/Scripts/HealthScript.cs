using UnityEngine;
using System.Collections.Generic;
using System;

public class HealthScript : MonoBehaviour {

    public List<GameObject> pixels = new List<GameObject>();
    public int health;
    private System.Random rand = new System.Random();

    public void damage(int amnt) {
        for (int i = amnt; i > 0; i--) {
            int intToDrop = rand.Next(pixels.Count - 1);
            GameObject dotToDrop = pixels[intToDrop];
            float shadeGrey = UnityEngine.Random.Range(0.0f, 0.5f);
            dotToDrop.GetComponent<SpriteRenderer>().color = new Color(shadeGrey, shadeGrey, shadeGrey, 0.5f);
            pixels.RemoveAt(intToDrop);
        }
        Debug.Log("Damaged");
    }

    public void initHealth(List<GameObject> dots) {
        pixels = dots;
        health = dots.Count;
    }
}
