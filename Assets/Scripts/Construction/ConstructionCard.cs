using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ConstructionCard : MonoBehaviour
{
    [SerializeField] private Construction _constriction;

    [SerializeField] private TMP_Text _name;
    [SerializeField] private TMP_Text _description;
    [SerializeField] private Image _image;

    public Construction ConstructionItem => _constriction;

    void Start()
    {
        if (_constriction.Type == ItemType.Resource)
        {   
            _name.text = _constriction.Name;
            _image.sprite = _constriction.Image;
        }
        else
        {
            Image image = GetComponent<Image>();

            _name.text = _constriction.Name;
            _description.text = _constriction.Description;
            image.sprite = _constriction.Image;
        }
    }

}
