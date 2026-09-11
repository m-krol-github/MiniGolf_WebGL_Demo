using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WebGolf
{
    public class MotionState : MonoBehaviour, IState<GameState>
    {
        public void DeinitState(GameState manager)
        {
            Debug.Log("<color=white> motion :: deinit</color>");
        }

        public void InitState(GameState manager)
        {
            Debug.Log("<color=white> motion :: init</color>");
        }

        public void UpdateState(GameState manager)
        {
            Debug.Log("<color=white> motion :: update</color>");
        }
    }
}