using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebGolf;

public class GameStateMachine : MonoBehaviour
{
    private IGameState current;
    private GameManager gameManager;

    public void InitThis(GameManager gameManager)
    {
        this.gameManager = gameManager;
    }

    public void ChangeState(IGameState next)
    {
        current?.Exit();
        current = next;
        current.Enter();
    }

    public void Tick() => current?.Update();
}