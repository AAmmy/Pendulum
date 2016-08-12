using UnityEngine;
using System.Collections;

public class Pendulum : MonoBehaviour {
	float g = 9.8f;

	public float get_angle(float theta0, float l){
		return -theta0 * Mathf.Cos (Mathf.Sqrt(g / l) * Time.time);
	}
}
