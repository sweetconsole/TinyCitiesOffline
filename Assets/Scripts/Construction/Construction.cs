using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Resource", menuName = "ScriptableObjects/Construction", order = 51)]
public class Construction : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private string _description;
    [SerializeField] private Sprite _image;
    [SerializeField] private ItemType _type;
    [SerializeField] private List<Construction> _lineOne = new List<Construction>();
    [SerializeField] private List<Construction> _lineTwo = new List<Construction>();
    [SerializeField] private List<Construction> _lineThree = new List<Construction>();

    public string Name => _name;
    public string Description => _description;
    public Sprite Image => _image;
    public ItemType Type => _type;
    public List<Construction> LineOne => _lineOne;
    public List<Construction> LineTwo => _lineTwo;
    public List<Construction> LineThree => _lineThree;
}

public enum ItemType 
{ 
    Cottage,      /* ����� */
    Monuments,    /* ���������� */
    Religion,     /* ��������� */
    Factory,      /* ��������� */
    Farm,         /* Ҹ��� ����� */
    Market,       /* ��������� */
    Extensions,   /* ����� */
    Tavern,       /* Ҹ��� ������ */
    Resource
}