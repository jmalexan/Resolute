using UnityEngine;
using System.Collections.Generic;

public class SpriteLoader : MonoBehaviour {

    public Sprite texture;
    private Color[] colors;
    private int pixelWidth;
    private int pixelHeight;
    public GameObject dotFab;

	// Use this for initialization
	void Start () {
        List<GameObject> dots = new List<GameObject>();
        PlayerScript script = GetComponent<PlayerScript>();
        colors = texture.texture.GetPixels();
        pixelWidth = texture.texture.width;
        pixelHeight = texture.texture.height;
        int colorIndex = 0;
        for (int ih = 0; ih < pixelHeight; ih++) {
            for (int iw = 0; iw < pixelWidth; iw++) {
                if (colors[colorIndex].a == 255) {

                }
                else
                {

                }
                GameObject dot = Instantiate(dotFab) as GameObject;
                dot.GetComponent<SpriteRenderer>().color = colors[colorIndex];
                dot.transform.position = new Vector2(iw, ih);
                dot.transform.SetParent(this.transform, false);
                colorIndex++;
                dots.Add(dot);
            }
            
        }
        script.pixels = dots; 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
