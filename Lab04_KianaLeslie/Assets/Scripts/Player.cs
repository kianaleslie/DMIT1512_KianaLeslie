using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject player;
   // int playerLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        //playerLives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        //if (playerLives == 0)
        //{
        //    Destroy(gameObject);
        //    GameSceneManager.LoadGameOver();
        //}
        //else
        //{
            if (Input.GetKey(KeyCode.D) && player.transform.position.x <= 8f)
            {
                transform.Translate(new Vector3(7 * Time.deltaTime, 0, 0));
            }
            if (Input.GetKey(KeyCode.A) && player.transform.position.x >= -8f)
            {
                transform.Translate(new Vector3(-7 * Time.deltaTime, 0, 0));
            }
        //}
    }
}
