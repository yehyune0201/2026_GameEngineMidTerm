using UnityEngine;

public class QuitGame : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();

        // 에디터에서 실행 중일 때 종료
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}