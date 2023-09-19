using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ConstructionCard))]
public class BuildingConstruction : MonoBehaviour
{
    [SerializeField] private Construction _construction;

    private void Start()
    {
        _construction = GetComponent<ConstructionCard>().ConstructionItem;
    }
}
