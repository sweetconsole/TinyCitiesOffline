using UnityEngine;

public class SwitchResources : MonoBehaviour
{
    [SerializeField] private Field _field;
    [SerializeField] private Construction _selectedConstruction;

    [SerializeField] private Construction resource1;
    [SerializeField] private Construction resource2;

    public void SelectConstruction(Construction construction)
    {
        _selectedConstruction = construction;

        _field.UpdateAccessSlots();
    }

    public void SelectSlot(FieldSlot slot)
    {   
        if (_selectedConstruction != null)
        {
            if (_selectedConstruction.Type == ItemType.Resource)
            {
                slot.SetConstruction(_selectedConstruction);

                _selectedConstruction = null;

                _field.ResetAccessSlots();
            }
            else if (_selectedConstruction.Type != ItemType.Resource)
            {
                 resource1 = _field.GetConstructionSlot(slot.Id);

                if (resource1 == _selectedConstruction.LineOne[0])
                {
                    resource2 = _field.GetConstructionSlot(slot.Id + 1);

                    if (resource2 == _selectedConstruction.LineOne[1])
                    {
                        Debug.Log("True");
                    }
                }



                Debug.Log(resource1.Name);
            }
        }

        resource1 = null;
        resource2 = null;
    }
}
