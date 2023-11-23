using System;
using Unity.Mathematics;
using UnityEngine;

public static class ExtensionMethods
{
    public static Vector3[] ToVector3Array(this Vector2[] a)
    {
        return Array.ConvertAll(a, (Vector2 v) => new Vector3(v.x, v.y, 0));
    }

    public static Vector3 ToVector3(this Vector2 v)
    {
        return new Vector3(v.x,v.y,0);
    }
    
    public static Vector2 ToVector2(this Vector3 v)
    {
        return new Vector2(v.x,v.y);
    }

    public static bool isNan(this Vector3 v)
    {
        return (float.IsNaN(v.x) || float.IsNaN(v.y) || float.IsNaN(v.z));
    }
    
    public static bool isNan(this Vector2 v)
    {
        return (float.IsNaN(v.x) || float.IsNaN(v.y));
    }

    public static Vector3 ChangeAxisX(this Vector3 v,float x)
    {
        return new Vector3(x,v.y,v.z);
    }
    public static Vector3 ChangeAxisY(this Vector3 v,float y)
    {
        return new Vector3(v.x,y,v.z);
    }
    public static Vector3 ChangeAxisZ(this Vector3 v,float z)
    {
        return new Vector3(v.x,v.y,z);
    }
    public static Vector2 ChangeAxisX(this Vector2 v,float x)
    {
        return new Vector2(x,v.y);
    }
    public static Vector2 ChangeAxisY(this Vector2 v,float y)
    {
        return new Vector2(v.x,y);
    }

    public static Vector2 RadiansToVector2(float angleInRads)
    {
        return new Vector2(MathF.Sin(angleInRads),MathF.Cos(angleInRads)); 
    }
    
    public static Vector2 DegreesToVector2(float angleInDegrees)
    {
        return RadiansToVector2(angleInDegrees * Mathf.Deg2Rad);
    }
    public static float Vector2ToDegrees(this Vector2 v)
    {
        v.Normalize();
        return Mathf.Atan2(v.x, v.y) * Mathf.Rad2Deg;
    }
}