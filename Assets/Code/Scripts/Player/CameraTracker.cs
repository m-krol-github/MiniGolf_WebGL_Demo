using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WebGolf
{
    public class CameraTracker : MonoBehaviour
    {
        [SerializeField] private Transform targetToTrack;
        [SerializeField, Range(-10,10)] private float offsetX;
        [SerializeField, Range(-10,10)] private float offsetY;

        private void LateUpdate()
        {
            if(targetToTrack != null)
                transform.position = targetToTrack.transform.position;
        }
    }
}