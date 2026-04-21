using UnityEngine;
using System.Collections;

public class Spin2D : MonoBehaviour
{
    public float rotationDuration = 0.5f; // 회전 시간
    private bool isSpinning = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && !isSpinning)
        {
            StartCoroutine(Spin());
        }
    }

    IEnumerator Spin() // 회전중 입니다.
    {
        isSpinning = true;

        float elapsed = 0f;
        float startZ = transform.eulerAngles.z;
        float endZ = startZ + 360f; // 360도 회전

        while (elapsed < rotationDuration)
        {
            float z = Mathf.Lerp(startZ, endZ, elapsed / rotationDuration);
            transform.eulerAngles = new Vector3(0, 0, z); 

            elapsed += Time.deltaTime;
            yield return null;
        }

        // 정확히 맞추기
        transform.eulerAngles = new Vector3(0, 0, endZ);

        isSpinning = false;
    }
}