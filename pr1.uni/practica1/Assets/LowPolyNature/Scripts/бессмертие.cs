using UnityEngine;

public class ImmortalityScript : MonoBehaviour
{
    private bool isImmortal = false;

    // Установите клавишу, которая будет включать/выключать бессмертие
    public KeyCode immortalityToggleKey = KeyCode.I;

    // Update вызывается один раз за кадр
    void Update()
    {
        // Проверяем, была ли нажата клавиша для включения/выключения бессмертия
        if (Input.GetKeyDown(immortalityToggleKey))
        {
            // Инвертируем текущее состояние бессмертия
            isImmortal = !isImmortal;

            // Если бессмертие включено, выведем сообщение в консоль
            if (isImmortal)
            {
                Debug.Log("Бессмертие включено!");
            }
            else
            {
                Debug.Log("Бессмертие выключено!");
            }
        }

        // Если бессмертие включено, игнорируем повреждения
        if (isImmortal)
        {
            // Поместите здесь любую дополнительную логику для бессмертного состояния
        }
    }
}

