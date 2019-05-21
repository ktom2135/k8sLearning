什么是namespace:

Namespace是对一组资源和对象的抽象集合，比如可以用来将系统内部的对象划分为不同的项目组或用户组

* namespace有什么用？
  
  可以用来划分k8s资源， 比如pod, service, deployment都可以用划分到不同到namespace下。 同一份yaml文件， 可以apply到不同的namespace


  * 请分别通过yaml文件和command，创建一个名为world的namespace

kubectl create namespace world

kubectl create -f ./namespace.yaml

可以使用kubectl get namespace来查看

* 请分别通过yaml文件和command，创建一个pod使其隶属于上述创建的namespace


kubectl apply -f coreapi.yaml  -n world

在namespace world2下创建一个pod， 
kubectl apply -f coreapi_pod_without_namespace.yaml -n world2


* 请分别通过yaml文件和command，将上述namespace的名字修改为universe


* 请使用command，查询所有namespace
kubectl get namespace


* 请使用command，查询universe中的所有pod

kubectl get pod -n world

* 请使用command，删除universe中的所有pod，但保留该namespace