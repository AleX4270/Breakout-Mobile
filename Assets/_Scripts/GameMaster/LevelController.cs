using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    [SerializeField] private GameController gameController;

    //Scene Management methods
    internal void proceedToNormalMode()
    {
        SceneManager.LoadScene("NormalMode");
    }

    internal void proceedToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    internal void quitGame()
    {
        Application.Quit();
    }
}
