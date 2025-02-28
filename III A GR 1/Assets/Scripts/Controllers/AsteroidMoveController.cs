using System;
using UnityEngine;


namespace Controllers
{
    public class AsteroidMoveController : MonoBehaviour
    {

        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private Vector2 direction;
        [SerializeField] private float speed;
        [SerializeField] private float angularVelocity;
        void Start()
        {
            InitMove();
        }

        private void FixedUpdate()
        {
            Rotation();
        }

        private void Rotation()
        {
            rb.angularVelocity = angularVelocity;
        }

        private void InitMove()
        {
            var force = new Vector2(1,1) * speed;
            rb.AddForce(force);
        }
    }
}