using TMPro;
using UnityEngine;

namespace Script.Game.Object
{
    public class Dice : MonoBehaviour
    {
        private int Roll()
        {
            return Random.Range(1, 101);

        }
        private void Start()
        {
            TMP_Text tMP_Text = GetComponent<TMP_Text>();
            tMP_Text.text= Roll().ToString();
        }

    }
}