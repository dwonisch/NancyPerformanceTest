using System;
using System.Collections.Generic;
using Nancy;
using Nancy.ViewEngines.Razor;

namespace NancyPerformanceTest
{
    public class ManufacturingControlCenterBootstrapper : DefaultNancyBootstrapper
    {
        
        public ManufacturingControlCenterBootstrapper()
        {
        }
        
        /// <summary>
        /// Gets the available view engine types
        /// </summary>
        protected override IEnumerable<Type> ViewEngines
        {
            get { yield return typeof(RazorViewEngine); }
        }
    }
}