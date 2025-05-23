using UnityEngine;

public class SendButton : MonoBehaviour
{
    [Header("Evaluate() �Լ��� ���� ������Ʈ")]
    [SerializeField] private CodeEvaluator codeEvaluator;

    public void SendCode()
    {
        if (codeEvaluator == null)
        {
            Debug.LogError("[SendButton] CodeEvaluator�� ����Ǿ� ���� �ʽ��ϴ�.");
            return;
        }

        codeEvaluator.Evaluate();
    }
}
