using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FinishGame : MonoBehaviour
{
    public HapticTrigger hapticTrigger;

    private void Start()
    {
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => GameFinish());

    }
    public void GameFinish()
    {
        hapticTrigger.TriggerHaptic();

        if (SceneTransitionManager.singleton != null)
        {
            SceneTransitionManager.singleton.GoToSceneAsync(0);
        }

    }

}
