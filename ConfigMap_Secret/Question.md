### 什么是ConfigMap, Secret, 分别有什么作用？

* ConfigMap是一种Kubenetes 的资源对象，可以将配置选项分离到独立ConfigMap中，其本质就是键值对，值可以是短字面值，也可以是完整的配置文件
* 



### 有几种方法可以向部署的app中传递参数？分别是什么？


###  如何在kubernetes中覆盖命令和参数？

### 利用kubectl 创建一个名为hello-config 的ConfigMap，里面有个映射条目为hello=world
kubectl create configmap hello-config --from-literal=hellp=world

查看yaml格式：
 kubectl get configmap hello-config -o yaml

 创建 多条记录：
kubectl create configmap hello-config --from-literal=hello=world --from-literal=hello-1=world-1 --from-literal=hello-2=world-2

从文件夹创建configmap:

 kubectl create configmap my-config-from-dir --from-file=./config

### kubectl create -f hello-config.yaml这个命令可以做什么？
kubectl create -f .\configMap.yaml
可以创建一个configmap

### 创建一个名为test的pod，将hello-config拷贝到pod.conf文件中，将该文件挂在到pod上，并检查是否使用被挂载的文件。
### 用命令行创建一个名为combine-config的ConfigMap，包含hello=world，以及animal.conf中的条目

从文件夹创建configmap:

 kubectl create configmap my-config-from-dir --from-file=./config


### 如果在pod中引用不存在的configmap会发生什么？
### 如何查找pod的敏感数据？
### 创建一个自己的generic Secret, 名字为my-secret, 在上次创建的pod上挂在my-secret