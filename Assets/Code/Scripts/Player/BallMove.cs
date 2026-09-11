using UnityEngine;
using System;


namespace WebGolf
{
    public class BallMove : BaseInput
    {
        [SerializeField] private Rigidbody rb;


        private GameManager gameManager;

        public void InitThis(GameManager gameManager)
        {
            this.gameManager = gameManager;
        }

        public override void OnEnable()
        {
            base.OnEnable();

            
        }

        private void Update()
        {
            //inputs.Movements.RotateCamera.ReadValue<Vector2>();
            inputs.Movements.Shoot.started += _ => shoot = true;
            inputs.Movements.Shoot.canceled += _ => shoot = false;
        }

        public override void Awake()
        {
            base.Awake();
            print(shoot);
        }

        public override void OnDisable()
        {
            base.OnDisable();
        }
    }
}