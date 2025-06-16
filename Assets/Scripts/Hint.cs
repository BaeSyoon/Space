using TMPro;
using UnityEngine;

public class Hint : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    public GameObject hintText;
    public StepManager stepManager;


    void Start()
    {
        if (hintText != null)
            hintText.SetActive(false);
        // SetHintText();
    }


    public void SetHintText()
    {
        GameStage stage = stepManager.currentStage;
        switch (stage)
        {
            case GameStage.PowerOn:
                textMeshPro.text = "비밀번호를 출력해 보세요.\n비밀번호: Hello World!";
                break;
            case GameStage.OxygenFix:
                textMeshPro.text = "조건문을 이용해 보세요.\n산소 비율 변수 = oxygen";
                break;
            case GameStage.DockRelease:
                textMeshPro.text = "반복문을 이용해 보세요.\n볼트 해제 함수 = release_bolt()";
                break;
            case GameStage.FlyAway:
                textMeshPro.text = "운전 함수 = navigate()\n근처 행성 탐지 결과 = Earth, Jupitor, Mars";
                break;
            case GameStage.Escape:
                textMeshPro.text = "반복문을 이용해 0000-9999까지 시도해 보세요.\n잠금해제 함수 = unlock(비밀번호)";
                break;
            case GameStage.Finish:
                textMeshPro.text = "버튼을 눌러 탈출하세요.";
                break;
            default:
                textMeshPro.text = "";
                break;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger 발생: " + other.name);
        if (hintText != null)
            hintText.SetActive(true);
        SetHintText();
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger 종료: " + other.name);
        if (hintText != null)
            hintText.SetActive(false);
    }
}
