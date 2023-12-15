using UnityEngine;

namespace Tasks.Task_6
{
    public class Level6 : MonoBehaviour
    {
        [SerializeField] private GameObject _obstacle;

        private float _speed = 5;

        private void Awake()
        {
            var newObstacle = Instantiate(_obstacle, new Vector3(0, 15, 0), Quaternion.identity);
        }

        private void Update()
        {
            var step = Time.deltaTime * _speed;
            var transformPosition = transform.position;
            transformPosition.x += step;

            transform.position = transformPosition;
        }
    }
}