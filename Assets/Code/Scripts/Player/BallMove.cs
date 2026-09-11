using UnityEngine;
using System;
using UnityEngine.Events;


namespace WebGolf
{
    public class BallMove : BaseInput
    {
        [SerializeField] private Rigidbody rb;

        public UnityAction ballShoot;

        private GameManager gameManager;

        public void InitThis(GameManager gameManager)
        {
            this.gameManager = gameManager;
        }

        public override void OnEnable()
        {
            base.OnEnable();
        }

        public override void Awake()
        {
            base.Awake();
            shoot = false;
            ballShoot = ShootBallCallback;
        }
        
        private void Update()
        {
            if(inputs.Movements.Shoot.WasPressedThisFrame())
                shoot = true;

            if(inputs.Movements.Shoot.WasReleasedThisFrame())
                shoot = true;
            //inputs.Movements.RotateCamera.ReadValue<Vector2>();
            inputs.Movements.Shoot.started += _ => shoot = true;
            inputs.Movements.Shoot.canceled += _ => shoot = false;
        }

        private void ShootBallCallback()
        {
            
        }

        public override void OnDisable()
        {
            base.OnDisable();
        }
    }
}