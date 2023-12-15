using UnityEngine;

namespace Tasks.Task_4
{
    public class Level4 : MonoBehaviour
    {
        public bool UseGravity = true;
        private float _speed = 15;

        private void Update()
        {
            var step = Time.deltaTime * _speed;
            var transformPosition = transform.position;
            transformPosition.x += step;

            transform.position = transformPosition; 
        }
    }
}