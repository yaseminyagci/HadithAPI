using System;

namespace Hadith.Core.CustomAttribute
{
  
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
    public class AuditLogIgnore : Attribute
    {
    }
}