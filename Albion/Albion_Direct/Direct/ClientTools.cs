////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.336.100246-prod
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Reflection;

namespace Albion_Direct
{
    /* Internal type: a8b */
    public partial class ClientTools
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        private static List<FieldInfo> _fieldReflectionPool = new List<FieldInfo>();
        
        private a8b _internal;
        
        #region Properties
        
        public a8b ClientTools_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public static GuiItemProxy GetStackProxy(ItemProxy A_0) => a8b.a((atl)A_0);
        public static int SomeCalculationWithUnfloatyFloats(Number A_0, Number A_1) => a8b.b((og)A_0, (og)A_1);
        
        #endregion
        
        #region Constructor
        
        public ClientTools(a8b instance)
        {
            _internal = instance;
        }
        
        static ClientTools()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a8b(ClientTools instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ClientTools(a8b instance)
        {
            return new ClientTools(instance);
        }
        
        public static implicit operator bool(ClientTools instance)
        {
            return instance._internal != null;
        }
        #endregion
    }
}
