using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIBerryPointValue : MonoBehaviour
    {
        [SerializeField] private Text berryPointValueText;

        public void OutputBerryPointValueOnUI(int pointValue)
        {
            berryPointValueText.text = $"+{pointValue}";
        }
    }
}

