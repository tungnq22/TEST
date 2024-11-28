using System.Runtime.InteropServices;
using UnityEngine;

public class OpenLinks : MonoBehaviour
{
    public string url = "https://vrbizos.io.vn/";

    void Update()
    {
        // Kiểm tra nếu người dùng nhấn phím R
        if (Input.GetKeyDown(KeyCode.R))
        {
            OpenURL(url);
        }
    }

    public static void OpenURL(string url)
    {
#if !UNITY_EDITOR && UNITY_WEBGL
        // Sử dụng ExternalCall thay vì ExternalEval
        Application.ExternalCall("openUrlInNewTab", url);
#else
        Application.OpenURL(url);
#endif
    }
}
