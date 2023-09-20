using UnityEngine;

public class SwitchResources : MonoBehaviour
{
    [SerializeField] private Field _field;
    [SerializeField] private Construction _selectedConstruction;

    public void SelectConstruction(Construction construction)
    {
        _selectedConstruction = construction;

        if (_selectedConstruction.Type == ItemType.Resource)
        {
            _field.UpdateAccessSlots();
        }
        else if (_selectedConstruction.Type != ItemType.Resource)
        {
            _field.UpdateAccessSlots(_selectedConstruction);
        }
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
                
            }
        }
    }
}
