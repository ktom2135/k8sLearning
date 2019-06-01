什么是存活探针？（liveness probe）

存活探针有那三种机制？

创建一个.net core api 项目， 该项目有个Get Api 路由时 /health， 访问到一定次数，（比如10次）的时候，返回400错误

将该项目发布到docker hub

基于该项目创建一个pod， 并且创建一个Http存活探针，探针指向 /health 接口， 该探针需要在容器启动后等待30秒再工作

查看pod重启原因，

什么是ReplicationController

ReplicationController 三部分都是什么？

创建一个ReplicationController, pod为上面的api项目，数量为3个

删除其中一个pod后，还有几个存在？

RelicationController中的某个Pod移出/移入其作用域

Pod移出ReplicationController的作用域后，其Pod数量是几个？

将Pod移入ReplicationController之后，其Pod数量是几个？

存活探针与ReplicationController有什么区别？

Pods被删除后，存活探针是否还起作用

