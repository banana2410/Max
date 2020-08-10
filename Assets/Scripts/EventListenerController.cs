using System.Collections;
using UnityEngine.Events;
using System.Collections.Generic;
using UnityEngine;

public class EventListenerController : MonoBehaviour
{
    [SerializeField] List<EventListenerStruct> _eventListenerStructs;

    public List<EventListenerStruct> EventListenerStructs { get => _eventListenerStructs; set => _eventListenerStructs = value; }

    private void OnEnable()
    {
        foreach (EventListenerStruct _event in _eventListenerStructs)
        {
            if (_event.ScriptableEvent != null)
                _event.ScriptableEvent.AddListener(this);
        }
    }
    private void OnDisable()
    {
        foreach (EventListenerStruct _event in _eventListenerStructs)
        {
            if (_event.ScriptableEvent != null)
                _event.ScriptableEvent.RemoveListener(this);
        }
    }
}

[System.Serializable]
public struct EventListenerStruct
{
    [Space(10)]
    [SerializeField] ScriptableEvent _scriptableEvent;
    [Space(10)]
    [SerializeField] UnityEvent _unityEvent;

    public ScriptableEvent ScriptableEvent { get => _scriptableEvent; set => _scriptableEvent = value; }
    public UnityEvent UnityEvent { get => _unityEvent; set => _unityEvent = value; }
}
