using UnityEngine;
using System.Collections;

public class Manager : MonoBehaviour {
	Pendulum pn = new Pendulum();
	HSV hsv = new HSV();

	float h;

	public float theta0 = 30, l = 10;
	float theta = 0;

	GameObject pole, point;

	// Use this for initialization
	void Start () {
		pole = gameObject.transform.FindChild("Pole").gameObject;
		point = gameObject.transform.FindChild("Point").gameObject;

		pole.transform.localScale = new Vector3(0.1f, l, 0.1f);
		pole.transform.localPosition = new Vector3(0, -l, 0);
		point.transform.localScale = new Vector3(1, 1, 1);
		point.transform.localPosition = new Vector3(0, -l * 2, 0);
	}
	
	// Update is called once per frame
	void Update () {
		h = (h + 10 * Time.deltaTime) % 360;
		h = adjustH(theta, -30, 30) / 3f * 2;
		point.transform.GetComponent<Renderer>().material.color = hsv.get_HSV((int)h);

		theta = pn.get_angle(theta0, l);
		this.transform.eulerAngles = new Vector3(0, 0, theta);
	}

	int adjustH(float h, float min, float max){
		return (int)((h - min) / (max - min) * 360);
	}
}
