using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WebGolf
{
    public class GameManager : BaseStateMachine<GameManager>
    {
        [SerializeField] private DataStorage storage;
        public DataStorage Storage => storage;

        public override void ChangeState(IState<GameManager> newState)
        {
            currentState?.DeinitState(this);
            currentState = newState;
            currentState?.InitState(this);
        }

        public override void UpdateChildState()
        {
            currentState?.UpdateState(this);
        }

        private void Awake()
        {
            Storage.Ball.Init(this);
            Storage.Trajectory.Init(this);
        }

        private void Update()
        {
            UpdateChildState();
        }
    }
}