using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public enum State
{
    running,
    paused
}

[CreateAssetMenu(menuName = "GameState")]
public class GameState : ScriptableObject
{
    private State bState;

    public event EventHandler<State> gameStatusChanged;

    public void changeGameState(bool freeze)
    {
        if (freeze)
        {
            this.bState = State.paused;
        }
        else
        {
            this.bState = State.running;
        }

        OnGameStatusChanged(this.bState);

    }

    public virtual void OnGameStatusChanged(State state)
    {
        gameStatusChanged?.Invoke(this, state);
    }
}
