using UnityEngine;

public class TapDetector : MonoBehaviour
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

        if (Input.GetMouseButtonDown(0))
        {
            tapDetected = true;
        }
    }

    public bool IsTapDetected()
    {
        return tapDetected;
    }
}
