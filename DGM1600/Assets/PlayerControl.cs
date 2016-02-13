using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {
    public float rotationSpeed;
    public float movementSpeed;
    private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
        rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void LateUpdate () {
	    if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -rotationSpeed, 0));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, rotationSpeed, 0));
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddRelativeForce(0, 0, movementSpeed);
        }
    }
}
