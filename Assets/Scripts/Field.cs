using UnityEngine;

public class Field : MonoBehaviour
{
    [SerializeField] private FieldSlot[] _slots;

    [SerializeField] private Methods _methods;

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

            bool[,] isBool = new bool[construction.SizeConstructionY, construction.SizeConstructionX];

            for (int i = 0; i < _slots.Length; i++)
            {
                if (_slots[i].Construction == construction.LineOne[0])
                {
                    slot = i;

                    for (int j = 0; j < construction.LineOne.Count; j++)
                    {
                        if (_slots[i+j].Construction == construction.LineOne[j])
                        {
                            isBool[0, j] = true;

                            _slots[i + j].SetAccessSlot(false);
                        }
                    }

                    for (int j = 0; j < construction.LineTwo.Count; j++)
                    {
                        if (_slots[i + j + 4].Construction == construction.LineTwo[j])
                        {
                            isBool[1, j] = true;

                            _slots[i + j + 4].SetAccessSlot(false);
                        }
                    }

                    for (int j = 0; j < construction.LineThree.Count; j++)
                    {
                        if (_slots[i + j + 8].Construction == construction.LineThree[j])
                        {
                            isBool[2, j] = true;

                            _slots[i + j + 8].SetAccessSlot(false);
                        }
                    }

                    _methods.Print2DArray(isBool);

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
