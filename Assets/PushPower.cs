using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Allows the player to push objects around 

public class PushPower : MonoBehaviour
{
    public float pushForce = 1;
 
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody _rigg = hit.collider.attachedRigidbody;
 
        if(_rigg != null)
        {
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();
 
            _rigg.AddForceAtPosition(forceDirection * pushForce, transform.position, ForceMode.Impulse);
        }
    }
}
