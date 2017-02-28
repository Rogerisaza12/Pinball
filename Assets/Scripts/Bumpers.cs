using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumpers : MonoBehaviour
{
    public float applyForce;

    void OnCollisionEnter2D(Collision2D other)
    {
        Vector3 direction = (other.transform.position - transform.position).normalized;
        AddForceToOther(other, direction);
        ChangeColor();
    }
    
    void AddForceToOther(Collision2D other, Vector3 direction)
    {
        other.gameObject.GetComponent<Rigidbody2D>().AddForce(direction * applyForce);
    }

    public virtual void ChangeColor()
    {

    }

}
