using UnityEngine;
using System.Collections;

public class HSV : MonoBehaviour {
	float s = 1, v = 1;

	public Color32 get_HSV(int h){
		Color32 c = new Color32();
		int i = (int)(h / 60f);
		float f = h / 60f - i; 
		byte p1 = (byte)(v * (1 - s) * 255);
		byte p2 = (byte)(v * (1 - s * f) * 255);
		byte p3 = (byte)(v * (1 - s * (1 - f)) * 255);
		byte vi = (byte)(v * 255);
		byte r = 0, g = 0, b = 0;
		switch(i){
		case 0: r = vi; g = p3; b = p1; break;
		case 1: r = p2; g = vi; b = p1; break;
		case 2: r = p1; g = vi; b = p3; break;
		case 3: r = p1; g = p2; b = vi; break;
		case 4: r = p3; g = p1; b = vi; break;
		case 5: r = vi; g = p1; b = p2; break;
		default: break;
		}
		c.a = 255;
		c.r = r;
		c.g = g;
		c.b = b;
		return c;
	}
}
