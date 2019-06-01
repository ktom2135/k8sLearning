什么是存活探针？（liveness probe）
存活探针有那三种机制？
创建一个.net core api 项目， 该项目有个Get Api 路由时 /health， 访问到一定次数，（比如10次）的时候，返回400错误
将该项目发布到docker hub
基于该项目创建一个pod， 并且创建一个Http存活探针，探针指向 /health 接口
 