using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	private Rigidbody rBody;
	public float speed;
	public float turnspeed;
	
	public float rotationX;
	public float rotationY;
	
	private void Start()
	{
		rBody = GetComponent<Rigidbody>();
	}

	void FixedUpdate()
	{
		
		/**
		 * Rotate the model based on the key press and adjusting speed for shift key
		 */
		if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w")) 
		{
			rBody.transform.position += rBody.transform.TransformDirection (Vector3.forward) * Time.deltaTime * speed * 3;
		}   
		
		else if (Input.GetKey ("w") && !Input.GetKey (KeyCode.LeftShift)) 
		{
			rBody.transform.position += rBody.transform.TransformDirection (Vector3.forward) * Time.deltaTime * speed;
		}   
		
		else if (Input.GetKey("s")) 
		{
			rBody.transform.position -= rBody.transform.TransformDirection (Vector3.forward) * Time.deltaTime * speed;
		}
 
		if (Input.GetKey("a") && !Input.GetKey("d")) 
		{
			rBody.transform.position += rBody.transform.TransformDirection (Vector3.left) * Time.deltaTime * speed;
		} 
		
		else if (Input.GetKey("d") && !Input.GetKey ("a")) 
		{
			rBody.transform.position -= rBody.transform.TransformDirection (Vector3.left) * Time.deltaTime * speed;
		}
	}

	void Update()
	{

		/**
		 * View movement based on mouse movement
		 */
		rotationX -= Input.GetAxis("Mouse Y") * Time.deltaTime * turnspeed;
		rotationY += Input.GetAxis("Mouse X") * Time.deltaTime * turnspeed;

		if (rotationX < -90)
		{
			rotationX = -90;
		}
		else if (rotationX > 90)
		{
			rotationX = 90;
		}

		transform.rotation = Quaternion.Euler(0, rotationY, 0);
		GameObject.FindWithTag("MainCamera").transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
	}
}