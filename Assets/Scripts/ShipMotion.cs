using UnityEngine;

public class ShipMotion : MonoBehaviour
{
    public float moveAmplitude = 0.5f;     // ��鸲 ��
    public float moveFrequency = 0.2f;     // �����̴� �ӵ�

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        float offset = Mathf.Sin(Time.time * moveFrequency) * moveAmplitude;
        transform.position = initialPosition + transform.forward * offset;
    }
}
