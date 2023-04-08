
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public static void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public static void LoadBreak()
    {
        SceneManager.LoadScene(1);
    }
    public static void LoadLevelOne()
    {
        SceneManager.LoadScene(2);
    }
    public static void LoadLevelTwo()
    {
        SceneManager.LoadScene(3);
    }
    public static void LoadGameOver()
    {
        SceneManager.LoadScene(4);
    }
}