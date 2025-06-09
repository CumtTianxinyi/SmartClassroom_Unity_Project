using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{
    public TMP_InputField inputA;
    public TMP_InputField inputB;
    public TMP_Text resultText;

    public void Add()
    {
        if (TryGetInputs(out float a, out float b))
            resultText.text = "Result: " + (a + b).ToString();
    }

    public void Subtract()
    {
        if (TryGetInputs(out float a, out float b))
            resultText.text = "Result: " + (a - b).ToString();
    }

    public void Multiply()
    {
        if (TryGetInputs(out float a, out float b))
            resultText.text = "Result: " + (a * b).ToString();
    }

    public void Divide()
    {
        if (TryGetInputs(out float a, out float b))
        {
            if (b == 0)
                resultText.text = "Error: Division by zero!";
            else
                resultText.text = "Result: " + (a / b).ToString("F2");
        }
    }

    private bool TryGetInputs(out float a, out float b)
    {
        bool validA = float.TryParse(inputA.text, out a);
        bool validB = float.TryParse(inputB.text, out b);

        if (!validA || !validB)
        {
            resultText.text = "Please enter valid numbers!";
            return false;
        }
        return true;
    }
    public void ResetFields()
    {
        inputA.text = "";
        inputB.text = "";
        resultText.text = "Result:";
    }

}

