using UnityEngine;


namespace Controllers
{
    public class ShootingController : MonoBehaviour
    {
        [SerializeField] private MissileMoveController missileMoveController;
        [SerializeField] private Transform spawnPosition;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        public void Shoot()
        {
            // 1. Spawn rakiety
            MissileMoveController spawnedObject = Instantiate(missileMoveController, spawnPosition.position, Quaternion.identity);
            spawnedObject.Move();
            Debug.Log("Fired !!!");
        }
    }

}
