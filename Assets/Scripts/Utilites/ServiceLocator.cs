using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServiceLocator : MonoBehaviour
{
    private static Dictionary<Type,object> _services = new Dictionary<Type, object>();
    
    public static void RegisterService<T>(T service)
    {
        _services.Add(typeof(T),service);
    }
    public static void RegisterService(object service)
    {
        _services.Add(service.GetType(),service);
    }
    public static T LocateService<T>()
    {
        if(_services.ContainsKey(typeof(T)))
            return (T)_services[typeof(T)];
        throw new Exception("Service not found: " + typeof(T).ToString());
    }

    public static bool ContainsService(Type type)
    {
        return _services.ContainsKey(type);
    }
    
    public static void Reset()
    {
        _services.Clear();
    }
}
