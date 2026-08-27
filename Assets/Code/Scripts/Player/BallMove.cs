using UnityEngine;
using System;

using UnityEngine.InputSystem;

namespace WebGolf
{
    public class BallMove : MonoBehaviour
    {
        private Inputs input;

        protected void Awake()
        {
            input = new Inputs();
        }

        private void OnEnable()
        {
            input.Enable();
        }

        private void OnDisable()
        {
            input.Disable();
        }
    }
}