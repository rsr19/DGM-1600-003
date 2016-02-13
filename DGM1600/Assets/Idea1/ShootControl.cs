using UnityEngine;
using System.Collections;

public class ShootControl : MonoBehaviour {
    public GameObject ammoPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = Instantiate(ammoPrefab);
            bullet.transform.position = transform.position;
            Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();
            rigidbody.AddForce(transform.eulerAngles);

        }
	}
}
