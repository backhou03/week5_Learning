using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private Player player;
    [SerializeField] private Image fillImage;
    private void OnEnable()
    {
        player.OnHp += UpdateHpbar;

    }
    private void OnDisable()
    {
        player.OnHp -= UpdateHpbar;
    }
    void UpdateHpbar(int current, int max)
    {
        fillImage.fillAmount = (float)current / max;
    }
}
