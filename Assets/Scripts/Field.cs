using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    [SerializeField] private FieldSlot[] _slots;

    public void UpdateAccessSlots()
    {
        for (int i = 0; i < _slots.Length; i++)
            _slots[i].UpdateAccessSlot();
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
