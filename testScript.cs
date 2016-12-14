using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class testScript : MonoBehaviour {

	Rigidbody rb;
	int left;
	int right;
	//int up;
//	int down;

	// Use this for initialization
	void Start () {
		Input.gyro.enabled = true;
		left = 0;
		right = 0;
		rb = GetComponent <Rigidbody> ();

	//	up = 0;
	//	down = 0;

	}
	
	// Update is called once per frame
	void Update () {
	//	transform.position = new Vector3(Mathf.Clamp(Time.time, -5.0F, 5.0F), 0, 0);

		float LA = Input.acceleration.x;
	//	float CA = Input.acceleration.y;
		float RA = Input.acceleration.z;
	//	float LG = Input.gyro.userAcceleration.x;
	//	float CG = Input.gyro.userAcceleration.y;
	//	float RG = Input.gyro.userAcceleration.z;
	

		//Debug.Log ("LA :-" + LA);
		//Debug.Log ("");

		if (LA > 1.0 && right < 1.0) //Right
		{

			rb.velocity = new Vector3 (1.4f, 5f, 0f);
		//	transform.position = new Vector3 (transform.position.x + 3.0F , transform.position.y ,transform.position.z);
			right++;
			left--;
		}
		if (LA < -1.0 && left < 1.0) //Left
		{
			
			rb.velocity = new Vector3 (-1.4f, 5f, 0f);
			//transform.position = new Vector3 (transform.position.x - 3.0F , transform.position.y ,transform.position.z);
			left++;
			right--;
		}
		if (RA > 0.2 ) //Up
		{
			rb.velocity = new Vector3 (0f, 5f, 0f);
			//transform.position = new Vector3 (transform.position.x , transform.position.y + 3.0F ,transform.position.z);
			//up++;
			//down--;
		}
		if (RA < -0.9 ) //Down
		{
			
			//transform.position = new Vector3 (transform.position.x, transform.position.y  - 3.0F  ,transform.position.z);
			//down++;
			//up--;
		}

	}
}


// To Do Task just remove the movement of Player in up and down. also reduce the movement of player in left and right (make right left animation in animatior).