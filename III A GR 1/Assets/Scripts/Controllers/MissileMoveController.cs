using UnityEngine;

namespace Controllers
{
    public class MissileMoveController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rb;
        [SerializeField] private Vector2 direction;

        public void Move()
        {
            rb.AddForce(direction);
        }
    }
}