using UnityEngine;
using System.Collections.Generic;

public class SpriteLoader : MonoBehaviour {

    public Sprite texture;
    private Color[] colors;
    private int pixelWidth;
    private int pixelHeight;
    public GameObject dotFab;

	public List<GameObject> initSprite() {
        Debug.Log("Initializing Sprite");
        List<GameObject> dots = new List<GameObject>();
        HealthScript script = GetComponent<HealthScript>();
        colors = texture.texture.GetPixels();
        pixelWidth = texture.texture.width;
        pixelHeight = texture.texture.height;
        int colorIndex = 0;
        for (int ih = 0; ih < pixelHeight; ih++) {
            for (int iw = 0; iw < pixelWidth; iw++) {
                if (colors[colorIndex].a != 255) {
                    GameObject dot = Instantiate(dotFab) as GameObject;
                    dot.GetComponent<SpriteRenderer>().color = colors[colorIndex];
                    dot.transform.position = new Vector2(iw, ih);
                    dot.transform.SetParent(this.transform, false);
                    dots.Add(dot);
                }
                colorIndex++;
            }
            
        }
        return dots;
	}
}
