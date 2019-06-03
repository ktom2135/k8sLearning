
#
*  
1. 什么是node？

k8s的节点，运行了docker, 可以通过kubectl 进行管理

2. 什么是pod?

k8s运行的最小单元， 是docker container的容器。

一个pod可以包含多个docker container同时运行，那么多个container都会在一个node中，不会跨node运行一个pod中的多个container

3. pod和node是什么关系？


4. pod和docker container是什么关系？
5. 基于第三次作业请回答以下问题：
6. 当前集群有几个node?

kubectl get nodes
7. 当前集群有几个pod？

kubectl get pod

8. 怎么查询asp.net core app所在的pod运行在哪个node上？

kubectl get pod -o wide

1.  #
* 
*  什么是labels？
*  * labels有什么用
labels是资源的标签，可以为k8s任意资源标记标签，可以通过标签进行资源管理。
比如可以让某些pod运行在某个标签的node下


*  请分别通过yaml文件和command，给任意pod加上以下标签：hello-label=world
```

apiVersion: apps/v1
kind: Deployment
metadata:
  name: coreapi
spec:
  replicas: 1
  selector:
    matchLabels:
      app: coreapi
  template:
    metadata:
      labels:
        app: coreapi
    spec:
      containers:
      - name: coreapi
        image: kedk2135/coreapi
        ports:
        - containerPort: 80
---
apiVersion: v1
kind: Service
metadata:
  name: coreapi
spec:
  type: LoadBalancer
  ports:
  - port: 80
  selector:
    app: coreapi

```

添加label:
```
kubectl label pods coreapi-9c8fcf94f-d5ftt  hello-label=world

```
*  请分别通过yaml文件和command，将上述标签修改为：hi-label=universe

```
kubectl get pod 

删除label
kubectl label pods coreapi-9c8fcf94f-d5ftt hello-label-

添加label
kubectl label pods coreapi-9c8fcf94f-d5ftt  hi-label=world
```

使用yaml文件更新：

```
kubectl apply -f aa.yaml
```

*  请使用command，查询：
*  * 含有标签"hi-label"的所有pod
```
 kubectl get pods -l 'hi-label'
```

*  * 不含有标签"hi-label"的所有pod

```
kubectl get pods -l '!hi-labela'

```
*  * 含有标签"hi-lable"且值为"universe"的所有pod

```
 kubectl get pods -l 'hi-label=universe'

```
*  * 含有标签"hi-lable"且值不为"universe"的所有pod

```
 kubectl get pods -l 'hi-label!=universe'

```

*  请使用command删除含有标签"hi-label"的所有pod

```
kubectl delete pod -l 'hi-label'

```
* #
* **part3 namespace**
* * 什么是namespace？
* * namespace有什么用？


- [ ] 请分别通过yaml文件和command，创建一个名为world的namespace

```

apiVersion: v1
kind: Namespace
metadata:
  name: world

kubectl create -f na.yaml

```

- [ ] 请分别通过yaml文件和command，创建一个pod使其隶属于上述创建的namespace



- [ ] 请分别通过yaml文件和command，将上述namespace的名字修改为universe

- [ ] 请使用command，查询所有namespace


- [ ] 请使用command，查询universe中的所有pod

- [ ] 请使用command，删除universe中的所有pod，但保留该namespace

