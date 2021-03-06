﻿#if (FEATURETOGGLE_FULL)

using FeatureToggle.Core;
using FeatureToggle.Providers;

namespace FeatureToggle.Toggles
{
    public abstract class SqlFeatureToggle : IFeatureToggle
    {
        protected SqlFeatureToggle()
        {
            ToggleValueProvider = new BooleanSqlServerProvider();
        }


        public virtual IBooleanToggleValueProvider ToggleValueProvider { get; set; }


        public bool FeatureEnabled
        {
            get { return ToggleValueProvider.EvaluateBooleanToggleValue(this); }
        }

    }
}

#endif