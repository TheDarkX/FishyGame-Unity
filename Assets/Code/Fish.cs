using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour {

    [SerializeField]
    private float _upwardForceMultipler = 100f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        /*
         Fire1 is a default button in Unity3D that is mapped to many things 
         [Space, Left-Ctrl, Left Click, A button (Xbox), X button (PS), etc].
        */
        bool pressedFireButton = Input.GetButton("Fire1"); 
        if (pressedFireButton)
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            // Vector3.zero is just a shortcut to get a Vector3 with 0 for all 3 of it’s values (X, Y, Z)
            rigidbody.velocity = Vector3.zero;
            rigidbody.AddForce(Vector3.up * _upwardForceMultipler);
        }

        if(transform.position.y > 6f || transform.position.y < -6f)
        {
            //Application.LoadLevel(0);
            SceneManager.LoadScene(0);
        }
	}
}
