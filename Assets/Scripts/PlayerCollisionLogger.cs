using UnityEngine;

public class PlayerCollisionLogger : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"[Player] �浹 ����: {collision.gameObject.name}");
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log($"[Player] �浹 ��... ���: {collision.gameObject.name}");
    }
}
