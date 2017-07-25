using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Common
{
    public class CustomModelBinder : DefaultModelBinder
    {
        protected override void BindProperty(ControllerContext controllerContext, ModelBindingContext bindingContext, PropertyDescriptor propertyDescriptor)
        {
            if(propertyDescriptor.PropertyType == typeof(int))
            {
                
            }

            base.BindProperty(controllerContext, bindingContext, propertyDescriptor);
        }
    }
}