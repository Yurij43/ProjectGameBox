using GlobalVars;
using UnityEngine;

namespace Berries
{
    public class BerryAnimationController : MonoBehaviour
    {
        [SerializeField] private Animator berryAnimator;

        public void RunPointValueAnimation()
        {
            berryAnimator.SetTrigger(GlobalStringVars.BerryPointAnimation);
        }
    }
}

