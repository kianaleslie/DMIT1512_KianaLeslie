
using TMPro;
using UnityEngine;

public class Collect2 : MonoBehaviour
{
    //private int coins = 0;
    [SerializeField] private TextMeshProUGUI coinText;
    private int gems = 0;
    [SerializeField] private FloatSO coinSO;
    //[SerializeField] private TextMeshProUGUI gemText;
    private void Start()
    {
        coinText.text = "Coins:" + coinSO.Value ;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
            coinSO.Value++;
            coinText.text = "Coins: " + coinSO.Value;
        }
        if (collision.gameObject.CompareTag("Gem"))
        {
            Destroy(collision.gameObject);
            gems++;
            //gemText.text = "Gems: " + gems;
            if (gems == 11)
            {
                GameSceneManager.LoadGameOver();
            }
        }
    }
}