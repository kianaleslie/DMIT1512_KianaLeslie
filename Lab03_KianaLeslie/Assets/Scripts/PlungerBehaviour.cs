using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlungerBehaviour : MonoBehaviour
{
    [SerializeField] SpringJoint2D plunger;
    public void Pull(float amount)
    {
        plunger.attachedRigidbody.AddForce(Vector2.down * amount * 16);
        plunger.distance = amount * 12f;
    }
}