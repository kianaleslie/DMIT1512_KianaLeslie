
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    [SerializeField] private GameObject[] wayPoints;
    private int currentWPIndex = 0;
    [SerializeField] private float speed = 2f; 
    private void Update()
    {
        if (Vector2.Distance(wayPoints[currentWPIndex].transform.position, transform.position) < .1f)
        {
            currentWPIndex++;
            if(currentWPIndex >= wayPoints.Length)
            {
                currentWPIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, wayPoints[currentWPIndex].transform.position, Time.deltaTime * speed);
    }
}