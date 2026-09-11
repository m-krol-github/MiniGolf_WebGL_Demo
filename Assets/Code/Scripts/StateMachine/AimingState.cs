using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace WebGolf
{
    public class AimingState : MonoBehaviour, IState<GameState>
    {
        public UnityAction OnAimCompleted;
        public UnityAction OnAimInterrupted;


        public void DeinitState(GameState manager)
        {
            Debug.Log("<color=yellow> Aimstate :: deinit</color>");
        }

        public void InitState(GameState manager)
        {
            Debug.Log("<color=yellow> Aimstate :: init</color>");
        }

        public void UpdateState(GameState manager)
        {
            Debug.Log("<color=yellow> Aimstate :: update</color>");
        }


    }
}