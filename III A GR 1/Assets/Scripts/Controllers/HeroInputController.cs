using UnityEngine;

namespace Controllers
{
    public class HeroInputController : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        [SerializeField] private ShootingController shootingController;

        void Update()
        {
            if (Input.GetButtonDown("Fire1"))
            {
                shootingController.shoot();
            }
        }
    }

}
