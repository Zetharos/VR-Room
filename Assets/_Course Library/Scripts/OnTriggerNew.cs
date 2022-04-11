using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/// <summary>
/// Calls functionality when a trigger occurs
/// </summary>
public class OnTriggerNew : MonoBehaviour
{

    [Serializable] public class TriggerEvent : UnityEvent<Collider> { }

    public TriggerEvent OnEnter = new TriggerEvent();
    public TriggerEvent OnExit = new TriggerEvent();

    private void OnTriggerEnter(Collider other)
    {
            OnEnter?.Invoke(other);
    }

    private void OnTriggerExit(Collider other)
    {
            OnExit?.Invoke(other);
    }

    private void OnValidate()
    {
        if (TryGetComponent(out Collider collider))
            collider.isTrigger = true;
    }
}
