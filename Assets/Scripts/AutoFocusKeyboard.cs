using System.Collections;
using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Experimental.UI;

public class AutoFocusKeyboard : MonoBehaviour
{
    [Header("���� ��� TMP InputField")]
    [SerializeField] private TMP_InputField inputField;

    [Header("VR Ű���� ���� ��ġ (��: Main Camera)")]
    [SerializeField] private Transform positionSource;

    [Header("Ű���� �Ÿ�/���� ����")]
    [SerializeField] private float distance = 0.5f;
    [SerializeField] private float verticalOffset = -0.5f;

    void Start()
    {
        StartCoroutine(FocusAndShowKeyboardNextFrame());
    }

    private IEnumerator FocusAndShowKeyboardNextFrame()
    {
        yield return null; // �� ������ ��� �� ����

        if (inputField == null)
        {
            Debug.LogError("[AutoFocusKeyboard] inputField ���� �ȵ�");
            yield break;
        }

        if (positionSource == null && Camera.main != null)
        {
            positionSource = Camera.main.transform;
        }

        // �Է� �ʵ忡 ��Ŀ�� ����
        inputField.Select();
        inputField.ActivateInputField();

        // Ű���� ǥ��
        NonNativeKeyboard.Instance.InputField = inputField;
        NonNativeKeyboard.Instance.PresentKeyboard(inputField.text);

        /*
        // Ű���� ��ġ �缳�� (optional)
        if (positionSource != null)
        {
            Vector3 direction = positionSource.forward;
            direction.y = 0;
            direction.Normalize();
            Vector3 targetPosition = positionSource.position + direction * distance + Vector3.up * verticalOffset;

            NonNativeKeyboard.Instance.RepositionKeyboard(targetPosition);
        }
        */

        // Ŀ�� ǥ��
        SetCaretAlpha(1);
    }

    private void SetCaretAlpha(float alpha)
    {
        inputField.customCaretColor = true;
        var caretColor = inputField.caretColor;
        caretColor.a = alpha;
        inputField.caretColor = caretColor;
    }
}
