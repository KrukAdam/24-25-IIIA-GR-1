using UnityEngine;

namespace Controllers
{
    public class HeroMoveController : MonoBehaviour
    {
        [SerializeField] private float speed = 1f;
        [SerializeField] private Rigidbody2D rb;

        void Update()
        {
            Rotation();
            Movement();
        }

        void Rotation()
        {
            var ui_mouse_position = Input.mousePosition;
            var mouse_position = Camera.main.ScreenToWorldPoint(ui_mouse_position);
            var relative_mouse_position = mouse_position - transform.position;
            relative_mouse_position.z = 0;

            float angle = Mathf.Atan2(relative_mouse_position.y, relative_mouse_position.x) * Mathf.Rad2Deg;
            rb.MoveRotation(angle);
        }


        void Movement()
        {
            var force = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed;
            rb.AddForce(force);
        }
    }

}
