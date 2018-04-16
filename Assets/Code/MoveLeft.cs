using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour {

    [SerializeField]
    private float _speed = 2.5f;
    [SerializeField]
    private bool _randomizeHeight = true;

    // Update is called once per frame
    void Update() {
        transform.Translate(Vector3.left * Time.deltaTime * _speed);
        if (transform.position.x < -10)
        {
            if (_randomizeHeight)
            {
                float randomYPosition = UnityEngine.Random.Range(-3, 3);
                transform.position = new Vector3(10, randomYPosition, 0);
            }
            else
            {
                transform.position = new Vector3(10, transform.position.y, 0);
            }
        }
	}
}
