////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.97446-live
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: es */
    public partial class MobCharacterDescriptor : CharacterDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private es _internal;
        
        #region Properties
        
        public es MobCharacterDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public MobCharacterDescriptor(es instance) : base(instance)
        {
            _internal = instance;
        }
        
        static MobCharacterDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator es(MobCharacterDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator MobCharacterDescriptor(es instance)
        {
            return new MobCharacterDescriptor(instance);
        }
        
        public static implicit operator bool(MobCharacterDescriptor instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}