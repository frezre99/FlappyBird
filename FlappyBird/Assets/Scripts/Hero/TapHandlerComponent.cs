using UnityEngine;

public class ScreenTapDetector : MonoBehaviour
{
    private bool tapDetected = false;

    void Update()
    {
        // ����� �������� tapDetected
        tapDetected = false;

        // �������� ������� �������
        if (Input.touchCount > 0)
        {
            // ��������� ������� �������
            Touch touch = Input.GetTouch(0);

            // �������� ��������� �������
            if (touch.phase == TouchPhase.Began)
            {
                // ��������� ����� tapDetected � true ��� ������ �������
                tapDetected = true;
            }
        }
    }

    public bool IsTapDetected()
    {
        return tapDetected;
    }
}
