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
    public State GState { get; private set; }

    public event EventHandler<State> gameStatusChanged;
    public void changeGameState(bool freeze)
    {
        if (freeze)
        {
            this.GState = State.paused;
        }
        else
        {
            this.GState = State.running;
        }

        OnGameStatusChanged(this.GState);

    }

    public virtual void OnGameStatusChanged(State state)
    {
        gameStatusChanged?.Invoke(this, state);
    }
}
