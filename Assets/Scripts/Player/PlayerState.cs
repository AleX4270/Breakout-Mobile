using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PState
{
    inGame,
    freezed
}

public class PlayerState : MonoBehaviour
{
    private PState pState;
    public PState PState
    {
        get 
        { 
            return pState; 
        }
    }

    public void freezePlayer(bool freeze)
    {
        pState = (freeze == true) ? PState.freezed : PState.inGame;  
    }

   
}
