using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Text = TMPro.TMP_Text;

public class GameManager : MonoBehaviour
{
    //public static int lives = 3;
    public static bool playGame = true;
    //public Text livesText;
    // Start is called before the first frame update
    void Start()
    {
        //livesText = GetComponent<Text>();
        //livesText.text = $"Lives: {lives}";
    }

    // Update is called once per frame
    void Update()
    {
        //livesText.text = $"Lives: {lives}";
        //if(lives == 0)
        //{
        //    GameSceneManager.LoadMainMenu();
        //}
    }
}