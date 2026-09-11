using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WebGolf
{
    public abstract class BaseStateMachine<T> : MonoBehaviour
    {
        protected IState<T> currentState;

        public abstract void ChangeState(IState<T> newState);
        public abstract void UpdateChildState();
    }
}