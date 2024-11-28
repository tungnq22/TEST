using UnityEngine;

public class CursorManager : MonoBehaviour
{
    void Start()
    {
        // Hiển thị con trỏ chuột
        Cursor.visible = true;

        // Đảm bảo con trỏ không bị khóa
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        // Đảm bảo con trỏ luôn hiển thị và không bị khóa trong suốt quá trình chạy game
        if (!Cursor.visible || Cursor.lockState != CursorLockMode.None)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
