using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WebGolf
{
    public class BallControll : MonoBehaviour
    {
        private GameManager gameManager;
        private BallPhysicsService physics =  new BallPhysicsService();
        private Vector3 velocity;

        public void Init(GameManager gameManager)
        {
            this.gameManager = gameManager;
        }

        public void Shoot(Vector3 direction, float force)
        {
            velocity = direction.normalized * force;
        }

        private void Update()
        {
            velocity = physics.ApplyPhysics(velocity);
            transform.position += velocity * Time.deltaTime;

            //todo: change state to ball stopped 
            //if(velocity.magnitude < 0.05f)
            //state change to ball holds position
        }

        public Vector3 Velocity => velocity;
    }
}