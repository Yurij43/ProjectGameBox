using UnityEngine;

namespace Player
{
    public class PlayerRotate : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer;

        public void FlipPlayer(float direction)
        {
            spriteRenderer.flipX = direction < 0 ? true : false;
        }
    }
}

