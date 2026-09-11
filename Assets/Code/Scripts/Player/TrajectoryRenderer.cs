using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace WebGolf
{
    public class TrajectoryRenderer : MonoBehaviour
    {
        [SerializeField] private TrajectoryPoint pointPrefab;

        [SerializeField] private List<TrajectoryPoint> trajectoryPoints = new List<TrajectoryPoint>(100);

        private GameManager gameManager;

        public void Init(GameManager gameManager)
        {
            this.gameManager = gameManager;

            //todo: use a pooling later
            for(int i = 0; i < 100; i++)
            {
                TrajectoryPoint point = Instantiate(pointPrefab, transform);
                point.gameObject.SetActive(false);
                trajectoryPoints.Add(point);
            }
        }

        public void ShowTrajectory(Vector3 startPos, Vector3 startVelocity, BallPhysicsService physics, float force)
        {
            int count = Mathf.Clamp(Mathf.RoundToInt(force * 4f), 10, 100);

            Vector3 pos = startPos;
            Vector3 vel = startVelocity;

            for(int i = 0; i < trajectoryPoints.Count; i++)
            {
                if(i < count)
                {
                    vel = physics.ApplyPhysics(vel);
                    pos += vel * Time.fixedDeltaTime;

                    trajectoryPoints[i].gameObject.SetActive(true);
                    trajectoryPoints[i].gameObject.transform.position = pos;

                    float t = (float)i / count;
                    float scale = Mathf.Lerp(.9f, .1f, t);

                    trajectoryPoints[i].gameObject.SetActive(false);
                }
                else
                {
                    trajectoryPoints[i].gameObject.SetActive(false);
                }
            }
        }

        public void Hide()
        {
            foreach(TrajectoryPoint point in trajectoryPoints)
            point.gameObject.SetActive(false);
        }
    }
}