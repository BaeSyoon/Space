using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class XRCharacterMover : MonoBehaviour
{
    public InputActionProperty moveAction; // XR Input�� 2D Vector

    public float moveSpeed = 1.5f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Vector2 input = moveAction.action.ReadValue<Vector2>();
        Vector3 direction = new Vector3(input.x, 0, input.y);

        // HMD ī�޶� ������ �������� �̵� ���� ��ȯ
        Transform cameraTransform = Camera.main.transform;
        Vector3 forward = Vector3.ProjectOnPlane(cameraTransform.forward, Vector3.up).normalized;
        Vector3 right = Vector3.ProjectOnPlane(cameraTransform.right, Vector3.up).normalized;

        Vector3 move = (forward * direction.z + right * direction.x) * moveSpeed;

        // �߷� ���� �� �ϸ� ���߿� �� �� �����Ƿ� �Ʒ� ���� �߰� ����
        move += Physics.gravity * Time.deltaTime;

        controller.Move(move * Time.deltaTime);
    }
}
