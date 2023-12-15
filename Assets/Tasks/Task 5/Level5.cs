using UnityEngine;

namespace Tasks.Task_5
{
    public class Level5 : MonoBehaviour
    {
        private float _speed = 5;
        
        // если использовать такой старт, то результат будет очень эффектным
        //private void Start()
        //{
        //    Instantiate(gameObject);
        //}

        private void Update()
        {
            var step = Time.deltaTime * _speed;
            var transformPosition = transform.position;
            transformPosition.x += step;

            transform.position = transformPosition; 
        }
    }
}