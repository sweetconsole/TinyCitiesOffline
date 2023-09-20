using UnityEngine;

public class Field : MonoBehaviour
{
    [SerializeField] private FieldSlot[] _slots;

    public void UpdateAccessSlots(Construction construction = null)
    {
        if (construction == null)
        {
            for (int i = 0; i < _slots.Length; i++)
                _slots[i].UpdateAccessSlot();
        }
        else
        {
            int slot = 0;

            for (int i = 0; i < _slots.Length; i++)
            {
                if (_slots[i].Construction == construction.LineOne[1])
                {
                    slot = i;
                    break;
                }
            }
        }
    }

    public void ResetAccessSlots()
    {
        for (int i = 0; i < _slots.Length; i++)
            _slots[i].ResetAccessSlot();
    }

    public Construction GetConstructionSlot(int id)
    {
        Construction construction = _slots[id].Construction;

        return construction;
    }
}
