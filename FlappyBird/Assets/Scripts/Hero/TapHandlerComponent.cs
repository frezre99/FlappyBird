using UnityEngine;

public class ScreenTapDetector : MonoBehaviour
{
    private bool tapDetected = false;

    void Update()
    {
        // Сброс значения tapDetected
        tapDetected = false;

        // Проверка наличия касаний
        if (Input.touchCount > 0)
        {
            // Получение первого касания
            Touch touch = Input.GetTouch(0);

            // Проверка состояния касания
            if (touch.phase == TouchPhase.Began)
            {
                // Установка флага tapDetected в true при начале касания
                tapDetected = true;
            }
        }
    }

    public bool IsTapDetected()
    {
        return tapDetected;
    }
}
