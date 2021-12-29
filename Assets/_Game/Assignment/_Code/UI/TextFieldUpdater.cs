using TMPro;
using UnityEngine;

namespace Assignment._Code.UI
{
    public class TextFieldUpdater : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private string _descriptionText;

        public void RefreshText(int value)
        {
            _text.text = _descriptionText + " " + value.ToString();
        }
    }
}
