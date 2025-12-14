using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverEffect : MonoBehaviour
{
    public float scaleSize = 1.1f;
    public float duration = 0.1f;

    private Vector3 defaultScale;

    void Start()
    {
        // 원래 크기 저장
        defaultScale = transform.localScale;
    }

    // 마우스가 들어왔을 때
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = defaultScale * scaleSize;
    }
    void OnDisable()
    {
        transform.localScale = defaultScale;
    }

    // 마우스가 나갔을 때
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = defaultScale;
    }
}