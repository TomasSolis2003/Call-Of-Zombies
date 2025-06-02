/*using UnityEngine;
using UnityEngine.EventSystems;

public class SimpleJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    private RectTransform background;
    private RectTransform handle;
    private Vector2 inputVector;

    void Start()
    {
        background = GetComponent<RectTransform>();
        handle = transform.GetChild(0).GetComponent<RectTransform>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(background, eventData.position, eventData.pressEventCamera, out pos);

        pos = Vector2.ClampMagnitude(pos, background.sizeDelta.x / 2f);
        handle.anchoredPosition = pos;

        inputVector = pos / (background.sizeDelta.x / 2f);
    }

    public void OnPointerDown(PointerEventData eventData) => OnDrag(eventData);
    public void OnPointerUp(PointerEventData eventData)
    {
        inputVector = Vector2.zero;
        handle.anchoredPosition = Vector2.zero;
    }

    public float Horizontal => inputVector.x;
    public float Vertical => inputVector.y;
}
*/
/*using UnityEngine;
using UnityEngine.EventSystems;

public class SimpleJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public RectTransform background;
    public RectTransform handle;
    public float handleLimit = 1f;
    public Vector2 InputDirection { get; private set; }

    private Vector2 _center;

    void Start()
    {
        _center = background.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 position = Vector2.zero;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(background, eventData.position, eventData.pressEventCamera, out position);

        position = Vector2.ClampMagnitude(position, background.sizeDelta.x / 2f);
        handle.anchoredPosition = position;

        InputDirection = position / (background.sizeDelta.x / 2f);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        InputDirection = Vector2.zero;
        handle.anchoredPosition = Vector2.zero;
    }
}
*/
using UnityEngine;
using UnityEngine.EventSystems;

public class SimpleJoystick : MonoBehaviour, IDragHandler, IPointerUpHandler, IPointerDownHandler
{
    public RectTransform background;
    public RectTransform handle;
    public float handleLimit = 1f;
    public Vector2 InputDirection { get; private set; }

    private Vector2 _center;

    void Start()
    {
        _center = background.position;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        OnDrag(eventData);
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 position;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(background, eventData.position, eventData.pressEventCamera, out position);

        position = Vector2.ClampMagnitude(position, background.sizeDelta.x / 2f);
        handle.anchoredPosition = position;

        InputDirection = position / (background.sizeDelta.x / 2f);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        InputDirection = Vector2.zero;
        handle.anchoredPosition = Vector2.zero;
    }
}
