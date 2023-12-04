
using UnityEngine;

public class Item : MonoBehaviour
{
    public enum ItemType
    {
        SpeedBoost,
        TimeExtend
    }

    public ItemType itemType;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ActivateItem();
            Destroy(gameObject);
        }
    }

    private void ActivateItem()
    {
        switch (itemType)
        {
            case ItemType.SpeedBoost:
                GameManager.Instance.ball.IncreaseSpeed();
                break;
            case ItemType.TimeExtend:
                GameManager.Instance.timer.AddTime(30f);
                break;
        }
    }
}
