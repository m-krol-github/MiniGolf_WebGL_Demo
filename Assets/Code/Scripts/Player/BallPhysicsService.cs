using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WebGolf
{
    public class BallPhysicsService 
    {
        public float mass = 10f;
        public float maxSpeed = 25f;
        public float baseDrag = 0.1f;
        public float extraDragFactor = 0.5f;

        public Vector3 ApplyPhysics(Vector3 velocity)
        {
            float speed = velocity.magnitude;

            float dynamicDrag = baseDrag + (1f - Mathf.Clamp01(speed / maxSpeed)) * extraDragFactor;
            velocity *= (1f - dynamicDrag * Time.deltaTime);

            if(velocity.magnitude > maxSpeed)
                velocity = velocity.normalized * maxSpeed;

            return velocity;
        }

    }
}