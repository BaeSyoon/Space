using UnityEngine;

public class SendButton : MonoBehaviour
{
    [Header("Evaluate() �Լ��� ���� ������Ʈ")]
    [SerializeField] private CodeEvaluator codeEvaluator;

    public void SendCode()
    {
        if (codeEvaluator == null)
        {
            return;
        }

        codeEvaluator.Evaluate();
    }
}
