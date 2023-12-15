using UnityEngine;

namespace Tasks.Task_1
{
    public class Level1 : MonoBehaviour
    {
        [SerializeField] private float _speed;
    
        private void Update()
        {
            var step = Time.deltaTime * _speed;
            var transformPosition = transform.position;
            transformPosition.x += step;

            transform.position = transformPosition;
        }
    }
}