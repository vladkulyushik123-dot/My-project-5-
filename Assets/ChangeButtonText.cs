using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonText : MonoBehaviour
{
    public Button buttonToChange; // кнопка, текст якої треба змінити
    private readonly string[] _randomTexts = { "Привіт", "Unity", "Кнопка", "Текст змінено" }; // масив випадкових рядків

    // Метод для зміни тексту кнопки
    public void ChangeText()
    {
        string randomText = _randomTexts[Random.Range(0, _randomTexts.Length)]; // вибираємо випадковий рядок
        buttonToChange.GetComponentInChildren<Text>().text = randomText; // змінюємо текст кнопки
    }
}