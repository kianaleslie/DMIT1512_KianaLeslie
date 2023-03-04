using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Text = TMPro.TMP_Text;

public class PlayerShip : MonoBehaviour
{
    [SerializeField] GameObject playerShip;
    [SerializeField] GameObject playerProjectile;
    [SerializeField] GameObject projectileChild;

    // Start is called before the first frame update
    void Start()
    {
        Data.playerLives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (Data.playerLives == 0)
        {
            Destroy(gameObject);
            GameManager.WinOrLose(Data.loseText);
            GameManager.LoadGameOver();
        }
        else
        {
            if (Keyboard.current.dKey.isPressed && gameObject.transform.position.x <= 8f)
            {
                transform.Translate(Vector3.left * Time.deltaTime * 7);
            }
            else if (Keyboard.current.aKey.isPressed && gameObject.transform.position.x >= -8f)
            {
                transform.Translate(Vector3.right * Time.deltaTime * 7);
            }
            shootPlayerProjectile();
        }
    }
    void shootPlayerProjectile()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            projectileChild = Instantiate(playerProjectile, new Vector3(playerShip.transform.position.x, playerShip.transform.position.y + 0.8f, 0), playerShip.transform.rotation) as GameObject;
        }
    }
}