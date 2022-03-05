using UnityEngine;
using System.Collections;




public class randomParticleRotation : MonoBehaviour {
	public bool x=false;
	public bool y=false;
	public bool z=false;
	
	void OnEnable() {
		if (x) {
			this.transform.localEulerAngles += new Vector3 (Random.value * 360f,0f,0f);
		}
		if (y) {
			this.transform.localEulerAngles += new Vector3 (0f,Random.value * 360f,0f);
		}
		if (z) {
			this.transform.localEulerAngles += new Vector3 (0f,0f,Random.value * 360f);
		}
	}
}