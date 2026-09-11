using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WebGolf
{
    public class GameState : BaseStateMachine<GameState>, IState<GameManager>
    {
        [field: SerializeField] public DataStorage storage { get; private set; }

        [SerializeField] private AimingState aiming;
        public AimingState Aiming => aiming;

        [SerializeField] private MotionState motion;
        public MotionState Motion => motion;

        [SerializeField] PauseState pause;
        public PauseState Pause => pause;

        private Inputs inputs;

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

        private void OnEnable()
        {
            inputs = new Inputs();
            inputs.Enable();
        }

        private void OnDisable()
        {
            inputs.Disable();
        }

        private void Update()
        {
            UpdateChildState();

            if(inputs.Movements.Action1.WasReleasedThisFrame())
                ChangeState(Aiming);

            if(inputs.Movements.Action2.WasReleasedThisFrame())
                ChangeState(Motion);

            if(inputs.Movements.Action3.WasReleasedThisFrame())
                ChangeState(Pause);
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
}