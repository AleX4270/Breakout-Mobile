using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    //public AudioManager audioMan;
    
    //public Animator anim;
    //public float animDuration;
    
    private IEnumerator loadScene(string sceneName)
    {
        //anim.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(0f);
        SceneManager.LoadScene(sceneName);
    }

    public void loadNormalMode()
    {
        //audioManager.PlaySound("btnClick");
        StartCoroutine(loadScene("NormalMode"));
    }

    public void loadArcadeMode()
    {
        //audioManager.PlaySound("btnClick");
        StartCoroutine(loadScene("ArcadeMode"));
    }

    public void loadHelpMenu()
    {
        //audioManager.PlaySound("btnClick");
        StartCoroutine(loadScene("helpMenu"));
    }

    public void loadCreditsMenu()
    {
        //audioManager.PlaySound("btnClick");
        StartCoroutine(loadScene("creditsMenu"));
    }

    public void loadSettingsMenu()
    {
        //audioManager.PlaySound("btnClick");
        StartCoroutine(loadScene("settingsMenu"));
    }

    public void quitGame()
    {
        //audioManager.PlaySound("btnClick");
        Application.Quit();
    }
}
