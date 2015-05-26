using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed;
    Rigidbody shot;

	void Start () {
        shot = GetComponent<Rigidbody>();
        shot.velocity = transform.forward * speed;
	}

}
