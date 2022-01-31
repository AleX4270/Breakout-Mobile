using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    inGame,
    freezed
}

public class PlayerState : MonoBehaviour
{
    private State pState;
    public State PState
    {
        get 
        { 
            return pState; 
        }
    }

    public void freezePlayer(bool freeze)
    {
        pState = (freeze == true) ? State.freezed : State.inGame;  
    }

   
}
