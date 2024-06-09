using UI;
using UnityEngine;

namespace Player
{
    public class PlayerKomboPoint : MonoBehaviour
    {
        [Header("Kombo vars")]
        [SerializeField] private int maxKomboValue;

        [Header("Settings")]
        [SerializeField] private UIKomboCount komboCountUI;
        
        private int kombo = 0;
        private int komboInitialValue = 0;

        public void ÑountKombo(bool komboActivation)
        {
            if (kombo < maxKomboValue && komboActivation)
            {
                kombo++;
                komboCountUI.OutputComboOnUI(kombo);
            }
            else
            {
                kombo = komboInitialValue;
                komboCountUI.OutputComboOnUI(kombo);
            }
        }

        public int SetScoreMultiplier()
        {
            return kombo;
        }
    }
}

