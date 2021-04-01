#Feature Toggle
This is an A/B testing feature but can also be used for CI/CD, just with updating appsettings you can go back to the old implementation of the functionality

Here we went with the default implementation steps:
* appsettings add section called **FeatureManagement**
* Add nugget Microsoft.FeatureManagement.AspNetCore to your project
* add to FeatureMangement section your seature name and bool


```
"FeatureManagement": {
    "PriorToReadyDataFetchingFeature": true
}
```

Further reading at https://docs.microsoft.com/en-us/azure/azure-app-configuration/use-feature-flags-dotnet-core?tabs=core5x
