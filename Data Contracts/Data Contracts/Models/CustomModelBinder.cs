using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using System.Web.Http.ValueProviders;

namespace Data_Contracts.Models
{
    public class CustomModelBinder<T> : IModelBinder
    {
        //public override bool IsMatch(Type t)
        //{
        //    return t == typeof(T);
        //}

        //public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        //{
        //    Type t = typeof(T);
        //    var entity = (bindingContext.Model ?? Activator.CreateInstance(t));

        //    // Cycle through the properties and assign values.
        //    foreach (PropertyInfo p in t.GetProperties())
        //    {
        //        string sourceKey;

        //        // this is what you'd do if you wanted to bind to the property name
        //        // string sourceKey = p.Name;

        //        // TODO bind sourceKey to the name in attribute DataMember

        //        Type propertyType = p.PropertyType;

        //        // now try to get the value from the context ...
        //        ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(sourceKey);
        //        if (valueResult != null)
        //        {
        //            bindingContext.ModelState.SetModelValue(sourceKey, valueResult);
        //            p.SetValue(entity, valueResult.ConvertTo(propertyType), null);
        //        }
        //    }
        //    return entity;
        //}

        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            throw new NotImplementedException();
        }
    }
}