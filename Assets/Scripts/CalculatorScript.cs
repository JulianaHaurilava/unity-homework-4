
using UnityEngine;
using System;
using TMPro;

public class CalculatorScript : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI signText;
    [SerializeField] private TextMeshProUGUI errorText;
    [SerializeField] private TextMeshProUGUI result;
    [SerializeField] private TMP_InputField firstInputNumber;
    [SerializeField] private TMP_InputField secondInputNumber;

    public void toAdd()
    {
        //double firstNumber, secondNumber;
        bool prov = (firstInputNumber.text == string.Empty || secondInputNumber.text == string.Empty); //?????? ????????, ?? ? ?? ?????? ??????? ??. ??????
        
        //if (!double.TryParse(firstInputNumber.text, out firstNumber) || !double.TryParse(secondInputNumber.text, out secondNumber))
        //{
        //    errorText.text = "????????? ???????? ???????????!";
        //    return;
        //}
        if (!prov) //?? ????? ? ???? ?????? ???????? ?? ?????????? ????. ? ??? ???????? ?????????? ??????????...
        {
            errorText.text = "";
            double outputNumber = Convert.ToDouble(firstInputNumber) + Convert.ToDouble(secondInputNumber);
            result.text = outputNumber.ToString("0.#######");
            signText.text = "+";
        }
        else errorText.text = "????????? ???????? ???????????!";
    }
    public void toSubtract()
    {
        double firstNumber, secondNumber;
        if (!double.TryParse(firstInputNumber.text, out firstNumber) || !double.TryParse(secondInputNumber.text, out secondNumber))
        {
            errorText.text = "????????? ???????? ???????????!";
            return;
        }
        errorText.text = "";
        double outputNumber = firstNumber - secondNumber;
        result.text = outputNumber.ToString("0.#######");
        signText.text = "-";
    }
    public void toMultiply()
    {
        double firstNumber, secondNumber;
        if (!double.TryParse(firstInputNumber.text, out firstNumber) || !double.TryParse(secondInputNumber.text, out secondNumber))
        {
            errorText.text = "????????? ???????? ???????????!";
            return;
        }
        errorText.text = "";
        double outputNumber = firstNumber * secondNumber;
        result.text = outputNumber.ToString("0.#######");
        signText.text = "*";
    }
    public void toDivide()
    {
        double firstNumber, secondNumber;
        if (!double.TryParse(firstInputNumber.text, out firstNumber) || !double.TryParse(secondInputNumber.text, out secondNumber))
        {
            errorText.text = "????????? ???????? ???????????!";
            return;
        }
        errorText.text = "";
        double outputNumber = firstNumber / secondNumber;
        result.text = outputNumber.ToString("0.#######");
        signText.text = "/";
    }


}
