using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barriers : MonoBehaviour
{
    [SerializeField] GameObject invaderProjectile;
    [SerializeField] GameObject barrier;
    public int counter = 0;
    void Update()
    {
        if (counter == 5)
        {
            barrier.GetComponent<Renderer>().material.color = Color.green;
        }
        if (counter == 7)
        {
            barrier.GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (counter == 9)
        {
            barrier.GetComponent<Renderer>().material.color = Color.red;
        }
        if (counter > 11)
        {
            Destroy(barrier);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "InvaderProjectile")
        {
            counter++;
        }
        if (collision.gameObject.tag == "Invaders")
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Boss")
        {
            Destroy(gameObject);
        }
    }
}