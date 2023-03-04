using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    float timer = 0;
    float movementTimer = 0.5f;
    int movementCount = 0;
    float speed = 0.25f;
    [SerializeField] GameObject boss;
    [SerializeField] GameObject bossProjectile;
    [SerializeField] GameObject projectileChild;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.playGame)
        {
            if (movementCount == 10)
            {
                transform.Translate(new Vector3(0, 0f, 0));
                movementCount = -1;
                speed = -speed;
                timer = 0;
            }
            timer += Time.deltaTime;
            if (timer > movementTimer && movementCount < 10)
            {
                transform.Translate(new Vector3(speed, 0, 0));
                timer = 0;
                movementCount++;
            }
            shootInvaderProjectile();
        }
    }
    void shootInvaderProjectile()
    {
        if (Random.Range(0f, 1500) < 1)
        {
            projectileChild = Instantiate(bossProjectile, new Vector3(boss.transform.position.x, boss.transform.position.y - 0.6f, 0), boss.transform.rotation) as GameObject;
        }
    }
}