# Extensions to the **Claims API** Microservice
The extensions below explore advanced features of AKS (Kubernetes) and additional open source solutions. Each extension (or sub-project) describes a particular use case and details the steps for implementing a potential solution using an advanced feature/capability.

- [Ingest Claims records using KEDA](./ingest-claims-keda)

   In this sub-project, claims records are read from an Azure storage queue and ingested into the backend data store via the Claims Web API.  The solution details the steps for using [Kubernetes-based Event Driven Autoscaling](https://docs.microsoft.com/en-us/azure/azure-functions/functions-kubernetes-keda) to process claims records at event driven scale in Kubernetes.