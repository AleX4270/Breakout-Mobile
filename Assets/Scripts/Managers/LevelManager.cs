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

    public void loadMainMenu()
    {
        //audioManager.PlaySound("btnClick");
        StartCoroutine(loadScene("MainMenu"));
    }
    
    public void loadArcadeMode()
    {
        
    }

    public void loadHelpMenu()
    {
        
    }

    public void loadCreditsMenu()
    {
        
    }

    public void loadSettingsMenu()
    {
        
    }

    public void quitGame()
    {
        //audioManager.PlaySound("btnClick");
        Application.Quit();
    }
}
