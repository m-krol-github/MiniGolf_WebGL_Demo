using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebGolf;


public class GameState : BaseStateMachine<GameState>, IState<GameManager>
{
    [SerializeField] private StartGame startGame;
    public StartGame StartGame => startGame;

    [SerializeField] private PlayGame playGame;
    public PlayGame PlayGame => playGame;

    [SerializeField] EndGame endGame;
    public EndGame EndGame => endGame;

    #region MainState
    public override void ChangeState(IState<GameState> newState)
    {
        currentState?.DeinitState(this);
        currentState = newState;
        currentState?.InitState(this);
    }

    public override void UpdateChildState()
    {
        currentState?.UpdateState(this);
    }

    #endregion

    #region SubStates

    public void InitState(GameManager manager)
    {

    }

    public void DeinitState(GameManager manager)
    {

    }


    public void UpdateState(GameManager manager)
    {

    }

    #endregion
}
