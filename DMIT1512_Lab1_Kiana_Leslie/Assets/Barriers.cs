using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barriers : MonoBehaviour
{
    [SerializeField] GameObject invaderProjectile;
    [SerializeField] GameObject barrier;
    public int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter > 5)
        {
            barrier.GetComponent<Renderer>().material.color = Color.blue;
        }
        if (counter > 15)
        {
            barrier.GetComponent<Renderer>().material.color = Color.magenta;
        }
        if (counter > 25)
        {
            barrier.GetComponent<Renderer>().material.color = Color.red;
        }
        if (counter > 35)
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
    }
}
