using UnityEngine;
using UnityEngine.UI;

public class FieldSlot : MonoBehaviour
{
    [SerializeField] private int _id;
    [SerializeField] private bool _isFull;
    [SerializeField] private Construction _construction;

    [Space]
    [Header("UI")]
    [SerializeField] private Sprite _empty;
    [SerializeField] private Image _item;

    [Space]
    [Header("Colors")]
    [SerializeField] private Color _white;
    [SerializeField] private Color _red;
    [SerializeField] private Color _green;

    [Space]
    [Header("Temp")]
    [SerializeField] private Image _access;

    public int Id => _id;
    public Construction Construction => _construction;

    private void Start()
    {
        _isFull = false;
        _item.sprite = _empty;
        _access = GetComponent<Image>();

        ResetAccessSlot();
    }

    public void SetConstruction(Construction construction)
    {
        if (!_isFull)
        {
            _construction = construction;
            _item.sprite = _construction.Image;
            _isFull = true;
        }
    }

    public void SetAccessSlot(bool access)
    {
        if (access == true)
            _access.color = _red;
        else
            _access.color = _green;
    }

    public void UpdateAccessSlot()
    {
        if (_isFull)
            _access.color = _red;
        else
            _access.color = _green;
    }

    public void ResetAccessSlot()
    {
        _access.color = _white;
    }
}
