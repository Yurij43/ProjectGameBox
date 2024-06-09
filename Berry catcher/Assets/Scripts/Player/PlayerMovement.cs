using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Movement vars")]
        [SerializeField] private float speed = 5f;

        [Header("Settings")]
        [SerializeField] private PlayerRotate playerRotate;

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        private Vector2 direction;

        public void OnMove(InputAction.CallbackContext context)
        {
            direction.x = context.ReadValue<float>();
        }

        private void FixedUpdate()
        {
            Move(direction);
        }

        public void Move(Vector2 direction)
        {         
            if (Mathf.Abs(direction.x) > 0.01f)
            {
                Vector2 newPosition = transform.position + new Vector3(direction.x, direction.y, 0) * speed * Time.fixedDeltaTime;
                transform.position = newPosition;
                playerRotate.FlipPlayer(direction.x);
            }          
        }    
    }
}

