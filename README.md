# Execute some tasks before your API is ready

Not too long ago, we deliverd our MVP, now we are developing a more robust solution. We had to implement a particular scenario where we went from InMemory lists loaded from appsettings.json to having a centralized service as a source of these InMemory lists. We where told to defer the ready state of our application for kubernetes until all records where loaded from the external service.

Since my team is very much in to CI/CD we decided to use a feature toggle to deliver value promptly and having a fail safe mechanism.
Here are the tools we used for this particular endevor

* [Feature toggle](./Docs/FeatureToggle.md)
* [Prior to ready task](./Docs/PriorToReadyTask.md)

I just felt like building a starwars contest API and while at the task using the tools mentioned before.
