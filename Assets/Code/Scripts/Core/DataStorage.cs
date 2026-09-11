using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WebGolf
{
    public class DataStorage : MonoBehaviour
    {
        [SerializeField] private GameManager manager;
        public GameManager Manager => manager;

        [SerializeField] private BallControll ball;
        public BallControll Ball => ball;

        [SerializeField] private TrajectoryRenderer trajectory;
        public TrajectoryRenderer Trajectory => trajectory;

    }
}