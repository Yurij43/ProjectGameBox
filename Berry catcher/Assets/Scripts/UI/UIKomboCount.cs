using UnityEngine;
using UnityEngine.UI;

namespace UI
{
    public class UIKomboCount : MonoBehaviour
    {
        [SerializeField] private Text komboText;

        public void OutputComboOnUI(int kombo)
        {
            if (kombo > 1)
            {
                komboText.text = $"KOMBO\nx{kombo}";
            }
            else
            {
                komboText.text = string.Empty;
            }
        }
    }
}

