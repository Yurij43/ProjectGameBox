using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerBoost : MonoBehaviour
    {
        [Header("Boost vars")]
        [SerializeField][Range(1, 5)] private float boostMultiplier;
        [SerializeField] private float boostDuration;

        [Header("Settings")]
        [SerializeField] private PlayerMovement playerMovement;

        private bool isBoosting = false;

        public void OnBoost(InputAction.CallbackContext context)
        {
            if (context.performed && !isBoosting)
            {
                StartCoroutine(BoostCoroutine());
            }          
        }

        private IEnumerator BoostCoroutine()
        {
            isBoosting = true;
            float originalSpeed = playerMovement.Speed;
            playerMovement.Speed *= boostMultiplier;
            yield return new WaitForSeconds(boostDuration);
            playerMovement.Speed /= boostMultiplier;
            isBoosting = false;
        }
    }
}

