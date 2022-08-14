using UnityEngine;
using System;
using TMPro;

public class CompareScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI signText;
    [SerializeField] private TextMeshProUGUI errorText;
    [SerializeField] private TMP_InputField firstInputNumber;
    [SerializeField] private TMP_InputField secondInputNumber;

    public void ToCompare()
    {
        double firstNumber, secondNumber;
        if (!double.TryParse(firstInputNumber.text, out firstNumber) || !double.TryParse(secondInputNumber.text, out secondNumber))
        {
            errorText.text = "¬веденные значени€ некорректны!";
            return;
        }
        errorText.text = "";
        if (firstNumber > secondNumber)
        {
            signText.text = ">";
        }
        else if (firstNumber < secondNumber)
        {
            signText.text = "<";
        }
        else signText.text = "=";

    }
}

