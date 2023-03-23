using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    [SerializeField] public GameObject ball;
    [SerializeField] public Transform spawn;
    protected GameState gameState;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //coroutine calls to wait() and wait yields for one second then moves the ball back to spawn 
        StartCoroutine(Wait(collision));
    }
    IEnumerator Wait(Collider2D collision)
    {
        yield return new WaitForSeconds(1);
        collision.transform.position = spawn.position;
        collision.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
    }
}