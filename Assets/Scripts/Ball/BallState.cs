using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BState
{
    inGame,
    freezed
}

public delegate void Status();

public class BallState : MonoBehaviour
{
    [SerializeField] private BallController ballController;
    private BState bState;

    public event EventHandler<BState> ballStatusChanged;

    public BState ballState
    {
        get { return bState; }
    }

    public void changeBallState(bool freeze)
    {
        if(freeze)
        {
            this.bState = BState.freezed;
        }
        else
        {
            this.bState = BState.inGame;
        }

        OnBallStatusChanged(this.bState);

    }

    public virtual void OnBallStatusChanged(BState state)
    {
        ballStatusChanged?.Invoke(this, state);
    }
}
