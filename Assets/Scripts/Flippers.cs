using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flippers : MonoBehaviour {

    public GameObject Derecha;
    public GameObject Izquierda;
    public float torqueForce;
    private Rigidbody2D derechaFlipper;
    private Rigidbody2D izquierdaFlipper;

	void Start ()
    {
        derechaFlipper = Derecha.GetComponent<Rigidbody2D>();
        izquierdaFlipper = Izquierda.GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        if (Input.GetKey(KeyCode.D))
            {
            AddTorque(derechaFlipper, -torqueForce);
            }
        if (Input.GetKey(KeyCode.A))
        {
            AddTorque(izquierdaFlipper, torqueForce);
        }

	}

    void AddTorque(Rigidbody2D rigid, float force)
    {
        rigid.AddTorque(force);
    }
}
