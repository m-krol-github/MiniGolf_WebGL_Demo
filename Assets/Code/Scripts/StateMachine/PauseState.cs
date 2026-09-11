using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WebGolf{
    public class PauseState : MonoBehaviour, IState<GameState>
    {
        public void DeinitState(GameState manager)
        {
            Debug.Log("<color=green> pause :: deinit</color>");
        }

        public void InitState(GameState manager)
        {
            Debug.Log("<color=green> pause :: init</color>");
        }

        public void UpdateState(GameState manager)
        {
            Debug.Log("<color=green> pause :: update</color>");
        }
    }
}