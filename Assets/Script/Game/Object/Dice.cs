using TMPro;
using UnityEngine;

namespace Script.Game.Object
{
    public class Dice : MonoBehaviour
    {
        private TMP_Text _diceText;
        private float RandomTime;
        private int Roll()
        {
            return Random.Range(1, 101);
        }
        public void Reset()
        {
            RandomTime = 0;
        }
        private bool Timer()
        {
            RandomTime += 4 * Time.deltaTime;
            if (RandomTime >= 5)
            {
                return false;
            }

            return true;
        }
        private void Start()
        {
            _diceText = GetComponent<TMP_Text>();
        }
        private void Update()
        {
            if (Timer())
            {
                _diceText.text = Roll().ToString();
            }
        }
    }
}